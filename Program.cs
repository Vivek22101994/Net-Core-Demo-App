using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplication4.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("Email"));

var connectionString = builder.Configuration.GetConnectionString("DefaltConnection");
builder.Services.AddScoped<IProduct,ProductService>();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddScoped<Common>();
builder.Services.AddScoped<AutoLogService>();

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
app.MapGet("/Notification", async (HttpContext ctx) =>
{
    var handler = new EndpointConecction(); // your class
    return await handler.Handle();
});
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();

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
