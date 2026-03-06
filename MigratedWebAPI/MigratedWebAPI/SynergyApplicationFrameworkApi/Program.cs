using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using SynergyApplicationFrameworkApi.Infrastructure.Data;
using SynergyApplicationFrameworkApi.Middleware;
using System.Reflection;

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/synergy-api-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);
    
    // Add Serilog
    builder.Host.UseSerilog();
    
    // Add services to the container
    builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
        });
    
    // Database Context (if using Entity Framework)
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (!string.IsNullOrEmpty(connectionString))
    {
        // TODO: Uncomment when DbContext is ready
        // builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //     options.UseSqlServer(connectionString));
    }
    
    // AutoMapper
    builder.Services.AddAutoMapper(typeof(Program));
    
    // TODO: Register Application Services (based on Pathway.ServicesWCF structure)
    // Example service registrations:
    // builder.Services.AddScoped<IContainerService, ContainerService>();
    // builder.Services.AddScoped<IDeliveryService, DeliveryService>();
    // builder.Services.AddScoped<IBatchService, BatchService>();
    
    // TODO: Register Repositories
    // Example repository registrations:
    // builder.Services.AddScoped<IContainerRepository, ContainerRepository>();
    
    // Health Checks
    builder.Services.AddHealthChecks();
    
    // API Explorer and Swagger
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Synergy Application Framework API",
            Version = "v1",
            Description = "Migrated from WCF to .NET 8 Web API with comprehensive documentation",
            Contact = new OpenApiContact
            {
                Name = "Development Team",
                Email = "dev@synergy.com"
            }
        });
        
        // Include XML comments for Swagger
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        if (File.Exists(xmlPath))
            options.IncludeXmlComments(xmlPath);
            
        // Enable annotations
        options.EnableAnnotations();
    });
    
    // CORS Configuration
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowSpecificOrigins", policy =>
        {
            policy.WithOrigins("http://localhost:3000", "https://localhost:3001")
                  .AllowAnyMethod()
                  .AllowAnyHeader()
                  .AllowCredentials();
        });
        
        // For development - allow all
        options.AddPolicy("AllowAll", policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
    });
    
    var app = builder.Build();
    
    // Configure the HTTP request pipeline
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Synergy API v1");
            c.RoutePrefix = string.Empty; // Serve Swagger at the root
            c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.List);
        });
        app.UseCors("AllowAll");
    }
    else
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
        app.UseCors("AllowSpecificOrigins");
    }
    
    // Global exception handling middleware
    app.UseMiddleware<ExceptionHandlingMiddleware>();
    
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    
    app.UseRouting();
    
    // Authentication & Authorization (uncomment when needed)
    // app.UseAuthentication();
    // app.UseAuthorization();
    
    // Health checks endpoint
    app.MapHealthChecks("/health");
    
    app.MapControllers();
    
    Log.Information("Starting Synergy Application Framework API");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
