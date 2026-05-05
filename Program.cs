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
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
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

app.MapGet("/api/admin/users", async (
    AppDbContext db,
    string? search,
    string? roleCode,
    bool? isActive,
    int page = 1,
    int pageSize = 10,
    CancellationToken cancellationToken = default) =>
{
    page = page < 1 ? 1 : page;
    pageSize = pageSize is < 1 or > 100 ? 10 : pageSize;

    var query = db.Tbl2014Users.AsNoTracking().AsQueryable();

    if (!string.IsNullOrWhiteSpace(search))
    {
        query = query.Where(x =>
            x.UserId.Contains(search) ||
            (x.UserDescription ?? string.Empty).Contains(search));
    }

    if (!string.IsNullOrWhiteSpace(roleCode))
    {
        query = query.Where(x => x.UserPermissionCode == roleCode);
    }

    if (isActive.HasValue)
    {
        query = query.Where(x => x.UserIsActived == isActive.Value);
    }

    var totalCount = await query.CountAsync(cancellationToken);

    var users = await query
        .OrderBy(x => x.UserId)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .Select(x => new UserAdminDto(
            x.UserId,
            x.UserPermissionCode,
            x.UserIsActived,
            x.UserIsLocked,
            x.UserDescription,
            x.AllowAccess,
            x.AllowDelete,
            x.AllowPreview,
            x.AllowApprove,
            x.AllowUpdate))
        .ToListAsync(cancellationToken);

    return Results.Ok(new PagedResult<UserAdminDto>(users, totalCount, page, pageSize));
}).RequireAuthorization("AdminOnly");

app.MapPost("/api/admin/users", async (AppDbContext db, CreateUserRequest request, CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(request.UserId) || string.IsNullOrWhiteSpace(request.Password) || string.IsNullOrWhiteSpace(request.UserPermissionCode))
    {
        return Results.BadRequest("User ID, password, and role are required.");
    }

    var exists = await db.Tbl2014Users.AnyAsync(x => x.UserId == request.UserId, cancellationToken);
    if (exists)
    {
        return Results.Conflict($"User '{request.UserId}' already exists.");
    }

    var roleExists = await db.Tbl2014UserPermissions.AnyAsync(x => x.UserPermissionCode == request.UserPermissionCode, cancellationToken);
    if (!roleExists)
    {
        return Results.BadRequest("Selected role does not exist.");
    }

    var entity = new Tbl2014User
    {
        UserId = request.UserId.Trim(),
        UserPassword = request.Password,
        UserPermissionCode = request.UserPermissionCode,
        UserIsActived = request.UserIsActive,
        UserIsLocked = request.UserIsLocked,
        UserDescription = request.UserDescription,
        AllowAccess = request.AllowAccess,
        AllowDelete = request.AllowDelete,
        AllowPreview = request.AllowPreview,
        AllowApprove = request.AllowApprove,
        AllowUpdate = request.AllowUpdate
    };

    db.Tbl2014Users.Add(entity);
    await db.SaveChangesAsync(cancellationToken);

    return Results.Created($"/api/admin/users/{entity.UserId}", new UserAdminDto(
        entity.UserId,
        entity.UserPermissionCode,
        entity.UserIsActived,
        entity.UserIsLocked,
        entity.UserDescription,
        entity.AllowAccess,
        entity.AllowDelete,
        entity.AllowPreview,
        entity.AllowApprove,
        entity.AllowUpdate));
}).RequireAuthorization("AdminOnly");

app.MapPut("/api/admin/users/{userId}", async (AppDbContext db, string userId, UpdateUserRequest request, CancellationToken cancellationToken) =>
{
    var entity = await db.Tbl2014Users.FirstOrDefaultAsync(x => x.UserId == userId, cancellationToken);
    if (entity is null)
    {
        return Results.NotFound();
    }

    var roleExists = await db.Tbl2014UserPermissions.AnyAsync(x => x.UserPermissionCode == request.UserPermissionCode, cancellationToken);
    if (!roleExists)
    {
        return Results.BadRequest("Selected role does not exist.");
    }

    entity.UserPermissionCode = request.UserPermissionCode;
    entity.UserIsActived = request.UserIsActive;
    entity.UserIsLocked = request.UserIsLocked;
    entity.UserDescription = request.UserDescription;
    entity.AllowAccess = request.AllowAccess;
    entity.AllowDelete = request.AllowDelete;
    entity.AllowPreview = request.AllowPreview;
    entity.AllowApprove = request.AllowApprove;
    entity.AllowUpdate = request.AllowUpdate;

    if (!string.IsNullOrWhiteSpace(request.Password))
    {
        entity.UserPassword = request.Password;
    }

    await db.SaveChangesAsync(cancellationToken);

    return Results.Ok(new UserAdminDto(
        entity.UserId,
        entity.UserPermissionCode,
        entity.UserIsActived,
        entity.UserIsLocked,
        entity.UserDescription,
        entity.AllowAccess,
        entity.AllowDelete,
        entity.AllowPreview,
        entity.AllowApprove,
        entity.AllowUpdate));
}).RequireAuthorization("AdminOnly");

app.MapGet("/api/admin/roles", async (AppDbContext db, string? search, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default) =>
{
    page = page < 1 ? 1 : page;
    pageSize = pageSize is < 1 or > 100 ? 10 : pageSize;

    var query = db.Tbl2014UserPermissions.AsNoTracking().AsQueryable();

    if (!string.IsNullOrWhiteSpace(search))
    {
        query = query.Where(x =>
            x.UserPermissionCode.Contains(search) ||
            x.UserPermissionEnglish.Contains(search) ||
            x.UserPermissionKhmer.Contains(search));
    }

    var totalCount = await query.CountAsync(cancellationToken);

    var roles = await query
        .OrderBy(x => x.UserPermissionCode)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .Select(x => new RoleAdminDto(
            x.UserPermissionId,
            x.UserPermissionCode,
            x.UserPermissionEnglish,
            x.UserPermissionKhmer,
            x.UserPermissionIsActived,
            x.UserPermissionDescription))
        .ToListAsync(cancellationToken);

    return Results.Ok(new PagedResult<RoleAdminDto>(roles, totalCount, page, pageSize));
}).RequireAuthorization("AdminOnly");

app.MapPost("/api/admin/roles", async (AppDbContext db, CreateRoleRequest request, CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(request.UserPermissionCode) || string.IsNullOrWhiteSpace(request.UserPermissionEnglish) || string.IsNullOrWhiteSpace(request.UserPermissionKhmer))
    {
        return Results.BadRequest("Role code, English name, and Khmer name are required.");
    }

    var exists = await db.Tbl2014UserPermissions.AnyAsync(x => x.UserPermissionCode == request.UserPermissionCode, cancellationToken);
    if (exists)
    {
        return Results.Conflict($"Role '{request.UserPermissionCode}' already exists.");
    }

    var nextId = (await db.Tbl2014UserPermissions.MaxAsync(x => (int?)x.UserPermissionId, cancellationToken) ?? 0) + 1;

    var entity = new Tbl2014UserPermission
    {
        UserPermissionId = nextId,
        UserPermissionCode = request.UserPermissionCode.Trim(),
        UserPermissionEnglish = request.UserPermissionEnglish,
        UserPermissionKhmer = request.UserPermissionKhmer,
        UserPermissionIsActived = request.UserPermissionIsActived,
        UserPermissionDescription = request.UserPermissionDescription
    };

    db.Tbl2014UserPermissions.Add(entity);
    await db.SaveChangesAsync(cancellationToken);

    return Results.Created($"/api/admin/roles/{entity.UserPermissionCode}", new RoleAdminDto(
        entity.UserPermissionId,
        entity.UserPermissionCode,
        entity.UserPermissionEnglish,
        entity.UserPermissionKhmer,
        entity.UserPermissionIsActived,
        entity.UserPermissionDescription));
}).RequireAuthorization("AdminOnly");

app.MapPut("/api/admin/roles/{roleCode}", async (AppDbContext db, string roleCode, UpdateRoleRequest request, CancellationToken cancellationToken) =>
{
    var entity = await db.Tbl2014UserPermissions.FirstOrDefaultAsync(x => x.UserPermissionCode == roleCode, cancellationToken);
    if (entity is null)
    {
        return Results.NotFound();
    }

    entity.UserPermissionEnglish = request.UserPermissionEnglish;
    entity.UserPermissionKhmer = request.UserPermissionKhmer;
    entity.UserPermissionIsActived = request.UserPermissionIsActived;
    entity.UserPermissionDescription = request.UserPermissionDescription;

    await db.SaveChangesAsync(cancellationToken);

    return Results.Ok(new RoleAdminDto(
        entity.UserPermissionId,
        entity.UserPermissionCode,
        entity.UserPermissionEnglish,
        entity.UserPermissionKhmer,
        entity.UserPermissionIsActived,
        entity.UserPermissionDescription));
}).RequireAuthorization("AdminOnly");

// Profile API for current user
app.MapGet("/api/profile/me", (HttpContext httpContext) =>
{
    if (httpContext.User?.Identity?.IsAuthenticated != true)
    {
        return Results.Unauthorized();
    }

    var username = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
    var displayName = httpContext.User.Identity?.Name ?? username;
    var roles = httpContext.User.FindAll(ClaimTypes.Role).Select(x => x.Value).Distinct().ToList();

    return Results.Ok(new ProfileDto(username, displayName, roles));
}).RequireAuthorization();

app.MapPost("/api/profile/change-password", async (HttpContext httpContext, ChangePasswordRequest request, IOptionsMonitor<DemoAuthOptions> options) =>
{
    if (httpContext.User?.Identity?.IsAuthenticated != true)
    {
        return Results.Unauthorized();
    }

    var username = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
    if (string.IsNullOrWhiteSpace(username))
    {
        return Results.Unauthorized();
    }

    var users = options.CurrentValue.Users;
    var user = users.FirstOrDefault(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
    if (user is null)
    {
        return Results.NotFound("User account is not available in configuration.");
    }

    if (!string.Equals(user.Password, request.CurrentPassword, StringComparison.Ordinal))
    {
        return Results.BadRequest("Current password is invalid.");
    }

    if (string.IsNullOrWhiteSpace(request.NewPassword) || request.NewPassword.Length < 6)
    {
        return Results.BadRequest("New password must be at least 6 characters.");
    }

    user.Password = request.NewPassword;

    await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return Results.Ok();
}).RequireAuthorization();

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
public sealed record UserAdminDto(
    string UserId,
    string UserPermissionCode,
    bool UserIsActive,
    bool UserIsLocked,
    string? UserDescription,
    bool? AllowAccess,
    bool? AllowDelete,
    bool? AllowPreview,
    bool? AllowApprove,
    bool? AllowUpdate);
public sealed record CreateUserRequest(
    string UserId,
    string Password,
    string UserPermissionCode,
    bool UserIsActive,
    bool UserIsLocked,
    string? UserDescription,
    bool? AllowAccess,
    bool? AllowDelete,
    bool? AllowPreview,
    bool? AllowApprove,
    bool? AllowUpdate);
public sealed record UpdateUserRequest(
    string UserPermissionCode,
    bool UserIsActive,
    bool UserIsLocked,
    string? UserDescription,
    bool? AllowAccess,
    bool? AllowDelete,
    bool? AllowPreview,
    bool? AllowApprove,
    bool? AllowUpdate,
    string? Password);
public sealed record RoleAdminDto(
    int UserPermissionId,
    string UserPermissionCode,
    string UserPermissionEnglish,
    string UserPermissionKhmer,
    bool UserPermissionIsActived,
    string? UserPermissionDescription);
public sealed record CreateRoleRequest(
    string UserPermissionCode,
    string UserPermissionEnglish,
    string UserPermissionKhmer,
    bool UserPermissionIsActived,
    string? UserPermissionDescription);
public sealed record UpdateRoleRequest(
    string UserPermissionEnglish,
    string UserPermissionKhmer,
    bool UserPermissionIsActived,
    string? UserPermissionDescription);
public sealed record ProfileDto(string Username, string DisplayName, IReadOnlyList<string> Roles);
public sealed record ChangePasswordRequest(string CurrentPassword, string NewPassword);
