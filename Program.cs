using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PharmacyExtra.Web.Models;
using PharmacyExtra.Web.Services.Auth;
using System.Data;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Configure database and services
// Connection string is read from appsettings.json (DefaultConnection)
var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(defaultConnection));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/login";
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromHours(8);
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CanEditMasterData", policy => policy.RequireRole("Admin", "Manager"));
});

builder.Services.AddCascadingAuthenticationState();

builder.Services.Configure<DemoAuthOptions>(builder.Configuration.GetSection("DemoAuth"));
builder.Services.PostConfigure<DemoAuthOptions>(options =>
{
    if (options.Users.Count == 0)
    {
        options.Users.Add(new DemoAuthUser
        {
            Username = "admin",
            Password = "admin123",
            DisplayName = "Demo Admin",
            Roles = ["Admin", "Manager", "Analyst"]
        });
    }
});

builder.Services.AddScoped(sp =>
{
    var navigationManager = sp.GetRequiredService<NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(navigationManager.BaseUri) };
});

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
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapRazorComponents<global::PharmacyExtra.Web.Components.App>()
    .AddInteractiveServerRenderMode();

app.MapPost("/auth/login", async (HttpContext httpContext, LoginRequest request, IOptions<DemoAuthOptions> options) =>
{
    var user = options.Value.Users.FirstOrDefault(u =>
        string.Equals(u.Username, request.Username, StringComparison.OrdinalIgnoreCase) &&
        string.Equals(u.Password, request.Password, StringComparison.Ordinal));

    if (user is null)
    {
        return Results.Unauthorized();
    }

    var claims = new List<Claim>
    {
        new(ClaimTypes.Name, string.IsNullOrWhiteSpace(user.DisplayName) ? user.Username : user.DisplayName),
        new(ClaimTypes.NameIdentifier, user.Username)
    };

    claims.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role)));

    var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));

    await httpContext.SignInAsync(
        CookieAuthenticationDefaults.AuthenticationScheme,
        principal,
        new Microsoft.AspNetCore.Authentication.AuthenticationProperties
        {
            IsPersistent = true,
            ExpiresUtc = DateTimeOffset.UtcNow.AddHours(8)
        });

    return Results.Ok();
});

app.MapPost("/auth/logout", async (HttpContext httpContext) =>
{
    await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return Results.Ok();
});

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

app.MapGet("/api/system/info", (IHostEnvironment environment) =>
{
    return Results.Ok(new SystemInfoDto(
        Environment.MachineName,
        environment.EnvironmentName,
        DateTimeOffset.UtcNow,
        ".NET 10",
        "PharmacyExtra.Web"));
});

app.MapGet("/api/dashboard/summary", async (AppDbContext db, CancellationToken cancellationToken) =>
{
    var summary = new DashboardSummaryDto(
        await db.Commodities.CountAsync(cancellationToken),
        await db.BudgetSources.CountAsync(cancellationToken),
        await db.Facilities.CountAsync(cancellationToken),
        await db.MainTransactions.CountAsync(cancellationToken),
        DateTimeOffset.UtcNow);

    return Results.Ok(summary);
});

app.MapGet("/api/budget-sources", async (AppDbContext db, string? search, string? type, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default) =>
{
    page = page < 1 ? 1 : page;
    pageSize = pageSize is < 1 or > 100 ? 10 : pageSize;

    var query = db.BudgetSources.AsNoTracking().AsQueryable();

    if (!string.IsNullOrWhiteSpace(search))
    {
        query = query.Where(x => (x.BudgetSourceId ?? string.Empty).Contains(search) || (x.BudgetSource1 ?? string.Empty).Contains(search));
    }

    if (!string.IsNullOrWhiteSpace(type))
    {
        query = query.Where(x => x.BudgetSourceType == type);
    }

    var total = await query.CountAsync(cancellationToken);

    var items = await query
        .OrderBy(x => x.BudgetSourceId)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .Select(x => new BudgetSourceDto(x.BudgetSourceId, x.BudgetSource1, x.BudgetSourceType))
        .ToListAsync(cancellationToken);

    return Results.Ok(new PagedResult<BudgetSourceDto>(items, total, page, pageSize));
});

app.MapPost("/api/budget-sources", async (AppDbContext db, BudgetSourceUpsertDto dto, CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(dto.BudgetSourceId))
    {
        return Results.BadRequest("BudgetSourceID is required.");
    }

    var existing = await db.BudgetSources.FindAsync([dto.BudgetSourceId], cancellationToken);
    if (existing is not null)
    {
        return Results.Conflict($"BudgetSourceID '{dto.BudgetSourceId}' already exists.");
    }

    var entity = new BudgetSource
    {
        BudgetSourceId = dto.BudgetSourceId.Trim(),
        BudgetSource1 = dto.BudgetSource,
        BudgetSourceType = dto.BudgetSourceType
    };

    db.BudgetSources.Add(entity);
    await db.SaveChangesAsync(cancellationToken);

    return Results.Created($"/api/budget-sources/{entity.BudgetSourceId}", new BudgetSourceDto(entity.BudgetSourceId, entity.BudgetSource1, entity.BudgetSourceType));
});

app.MapPut("/api/budget-sources/{id}", async (AppDbContext db, string id, BudgetSourceUpsertDto dto, CancellationToken cancellationToken) =>
{
    var entity = await db.BudgetSources.FindAsync([id], cancellationToken);
    if (entity is null)
    {
        return Results.NotFound();
    }

    entity.BudgetSource1 = dto.BudgetSource;
    entity.BudgetSourceType = dto.BudgetSourceType;

    await db.SaveChangesAsync(cancellationToken);
    return Results.Ok(new BudgetSourceDto(entity.BudgetSourceId, entity.BudgetSource1, entity.BudgetSourceType));
});

app.MapDelete("/api/budget-sources/{id}", async (AppDbContext db, string id, CancellationToken cancellationToken) =>
{
    var entity = await db.BudgetSources.FindAsync([id], cancellationToken);
    if (entity is null)
    {
        return Results.NotFound();
    }

    db.BudgetSources.Remove(entity);
    await db.SaveChangesAsync(cancellationToken);
    return Results.NoContent();
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

public sealed record DashboardSummaryDto(int Commodities, int BudgetSources, int Facilities, int MainTransactions, DateTimeOffset GeneratedAtUtc);
public sealed record SystemInfoDto(string MachineName, string Environment, DateTimeOffset GeneratedAtUtc, string Runtime, string Application);
public sealed record BudgetSourceDto(string BudgetSourceId, string? BudgetSource, string? BudgetSourceType);
public sealed record BudgetSourceUpsertDto(string BudgetSourceId, string? BudgetSource, string? BudgetSourceType);
public sealed record PagedResult<T>(IReadOnlyList<T> Items, int TotalCount, int Page, int PageSize);
public sealed record LoginRequest(string Username, string Password);
