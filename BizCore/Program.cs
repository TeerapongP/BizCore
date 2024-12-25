using BizCore.AppDbContexts;
using BizCore.ServiceRegistration;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Initialize Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()  // Log to Console
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day) // Log to File
    .CreateLogger();

try
{
    Log.Information("Starting up the application");

    // Use Serilog as the logging provider
    builder.Host.UseSerilog();

    // Read connection string from appsettings.json (optional)
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Database connection string is not found.");
    }

    // Register DbContext or other services
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(connectionString));

    // Add custom services
    builder.Services.AddCustomServices();

    // Add controllers
    builder.Services.AddControllers();

    // Add Swagger for API documentation
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Enable Swagger UI only for development
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // Enable HTTPS redirection and logging for HTTP requests/responses
    app.UseHttpsRedirection();
    app.UseSerilogRequestLogging(); // Log HTTP request/response data
    app.UseAuthorization();

    // Map controllers to routes
    app.MapControllers();

    // Run the application
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application startup failed!");
}
finally
{
    Log.CloseAndFlush(); // Ensure all logs are flushed
}