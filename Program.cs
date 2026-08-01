using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
using WebApplication4.Models;
using WebApplication4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add JWT Configuration
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];

if (!string.IsNullOrEmpty(secretKey))
{
    var key = Encoding.ASCII.GetBytes(secretKey);

    builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = !string.IsNullOrEmpty(jwtSettings["Issuer"]),
            ValidIssuer = jwtSettings["Issuer"],
            ValidateAudience = !string.IsNullOrEmpty(jwtSettings["Audience"]),
            ValidAudience = jwtSettings["Audience"],
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });
}

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("Email"));

var connectionString = builder.Configuration.GetConnectionString("DefaltConnection");
builder.Services.AddScoped<IProduct, ProductService>();
builder.Services.AddScoped<IPasswordHasher<UsrAdmin>, PasswordHasher<UsrAdmin>>();
builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();
builder.Services.AddScoped<Common>();
builder.Services.AddSingleton<AutoLogService>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddOutputCache();

// Register the DbContext as a service
builder.Services.AddDbContextPool<MyDbContext>(options =>
     options.UseSqlServer(connectionString)// Use the appropriate provider (e.g., UseSqlite, UseMySql)
);
builder.Services.AddHangfire((sp, confir) =>
{    
    var connectionString = builder.Configuration.GetConnectionString("HangFireConnection"); 
    confir.UseSqlServerStorage(connectionString);
});
builder.Services.AddHangfireServer();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/Detail");
    app.UseStatusCodePagesWithReExecute("/Error/Detail/{0}");
}
app.MapGet("/Notification", async () =>
{
    var handler = new EndpointConecction(); // Calling the Handle method of the NotificationHandler class
    return await handler.Handle(); // Calling And Retrun the Result
});
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseHangfireDashboard("/hangfire/dashboard",new DashboardOptions
{
    DashboardTitle = "Test Project Hangire Dashboard",
    DisplayStorageConnectionString = false
});
// To Minal APi's Or Called Custom MiddleWare Which Defined in Program.cs
app.MapPost("/products", (Product p) =>
{
    return Results.Created($"/products/{p.Id}", p);
});
RecurringJob.AddOrUpdate<AutoLogService>(
    "Send Notification Job",
    x => x.AddLog(),
    Cron.MinuteInterval(1));

BackgroundJob.Enqueue<AutoLogService>(x => x.AddLog());
app.UseRouting();
app.UseOutputCache();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");


app.Run();
