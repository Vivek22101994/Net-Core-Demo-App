using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;
using System.Text.Json;
using System.Threading.RateLimiting;
using WebApplication4.Models;
using WebApplication4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add RateLimit Configuration For Prevent Abuse Traffic
builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 5;
        opt.Window = TimeSpan.FromSeconds(30);
    });
    options.AddPolicy("PerIpPolicy", httpContext =>
        RateLimitPartition.GetFixedWindowLimiter(
            httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown",
            _ => new FixedWindowRateLimiterOptions
            {
                PermitLimit = 5,
                Window = TimeSpan.FromSeconds(30)
    }));
    options.OnRejected = async (context, cancellationToken) =>
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
        context.HttpContext.Response.ContentType = "application/json"; 
        var error = new
        {           
            error = "TooManyRequests",
            message = "You have exceeded the allowed request limit. Please try again later.",           
        };
        await context.HttpContext.Response.WriteAsync(
            JsonConvert.SerializeObject(error), cancellationToken);
    };
});
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
        options.Events = new JwtBearerEvents
        {
            // Fires when there's no token, or token is invalid/expired

            OnAuthenticationFailed = context =>
            {
                if (context.Exception is SecurityTokenExpiredException) // Check Logic Of Wether Token Expired Or Not And Set Result HttpContext
                {
                    // Flag it so OnChallenge can read this later
                    context.HttpContext.Items["auth-error"] = "token_expired";
                }
                else
                {
                    context.HttpContext.Items["auth-error"] = "token_invalid";
                }
                return Task.CompletedTask;
            },
            OnMessageReceived = context =>
            {
                context.Token =
                    context.Request.Cookies["access_token"];

                return Task.CompletedTask;
            },
            OnChallenge = async context =>
            {
                string errorCode = context.HttpContext.Items["auth-error"] as string ?? "token_missing";
                context.HandleResponse(); // stop default behavior
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Response.ContentType = "application/json";
                string messageErrpr = errorCode switch
                {
                    "token_expired" => "Unauthorized Access token has expired. Use refresh token to obtain a new one.",
                    "token_invalid" => "Unauthorized Access token is invalid.",
                    _ => "Authentication token is missing."
                };
                var result = new 
                { 
                    message = messageErrpr
                };
                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }           
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
builder.Services.AddSingleton<KafkaProducerService>();
builder.Services.AddHostedService<KafkaConsumerService>();

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
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});
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
app.UseCors("ReactPolicy");
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
app.UseRateLimiter();
app.UseAuthentication();   
app.UseAuthorization();
app.UseOutputCache();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");


app.Run();
