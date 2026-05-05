using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PharmacyExtra.Web.Models;
using Microsoft.Extensions.Logging;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure database and services
// Connection string is read from appsettings.json (DefaultConnection)
var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(defaultConnection));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<global::PharmacyExtra.Web.Components.App>()
    .AddInteractiveServerRenderMode();

app.MapGet("/health", async (IServiceProvider services, IConfiguration configuration, CancellationToken cancellationToken) =>
{
    var connection = configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrWhiteSpace(connection))
    {
        return Results.Json(new
        {
            status = "Unhealthy",
            app = "Healthy",
            database = "NotConfigured",
            reason = "ConnectionStrings:DefaultConnection is not configured"
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }

    try
    {
        using var scope = services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var canConnect = await context.Database.CanConnectAsync(cancellationToken);

        if (canConnect)
        {
            return Results.Ok(new
            {
                status = "Healthy",
                app = "Healthy",
                database = "Reachable"
            });
        }

        return Results.Json(new
        {
            status = "Unhealthy",
            app = "Healthy",
            database = "Unreachable"
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }
    catch (Exception ex)
    {
        return Results.Json(new
        {
            status = "Unhealthy",
            app = "Healthy",
            database = "Error",
            error = ex.Message
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }
});

app.MapGet("/health/db", async (IServiceProvider services, IConfiguration configuration, CancellationToken cancellationToken) =>
{
    var connection = configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrWhiteSpace(connection))
    {
        return Results.Json(new
        {
            status = "Unhealthy",
            reason = "ConnectionStrings:DefaultConnection is not configured"
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }

    try
    {
        using var scope = services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var canConnect = await context.Database.CanConnectAsync(cancellationToken);

        if (canConnect)
        {
            return Results.Ok(new
            {
                status = "Healthy",
                database = "Reachable"
            });
        }

        return Results.Json(new
        {
            status = "Unhealthy",
            database = "Unreachable"
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }
    catch (Exception ex)
    {
        return Results.Json(new
        {
            status = "Unhealthy",
            database = "Error",
            error = ex.Message
        }, statusCode: StatusCodes.Status503ServiceUnavailable);
    }
});

// Ensure database is created and optionally seed data at startup
if (!string.IsNullOrWhiteSpace(defaultConnection))
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var logger = services.GetService<ILogger<Program>>();

    try
    {
        var context = services.GetRequiredService<AppDbContext>();

        var hasAppliedMigrations = context.Database.GetAppliedMigrations().Any();
        var hasUserTables = DatabaseHasUserTables(context);

        if (!hasAppliedMigrations && hasUserTables)
        {
            logger?.LogWarning("Database contains existing tables but has no EF migration history. Skipping automatic migration to avoid conflicts.");
        }
        else
        {
            context.Database.Migrate();
        }

        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        logger?.LogError(ex, "An error occurred while migrating or initializing the database.");
    }
}
else
{
    app.Logger.LogWarning("ConnectionStrings:DefaultConnection is not configured. Database migration and seeding were skipped.");
}

app.Run();

static bool DatabaseHasUserTables(AppDbContext context)
{
    var connection = context.Database.GetDbConnection();
    var shouldClose = connection.State != ConnectionState.Open;

    if (shouldClose)
    {
        connection.Open();
    }

    try
    {
        using var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT COUNT(*)
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_TYPE = 'BASE TABLE'
              AND TABLE_NAME <> '__EFMigrationsHistory'";

        var result = command.ExecuteScalar();
        var tableCount = result is null ? 0 : Convert.ToInt32(result);
        return tableCount > 0;
    }
    finally
    {
        if (shouldClose)
        {
            connection.Close();
        }
    }
}
