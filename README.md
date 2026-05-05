# PharmacyExtra

ASP.NET Core Razor Components project with EF Core models scaffolded from an existing SQL Server database (PharmacyExtra).

## Prerequisites
- .NET 8 SDK
- SQL Server (localhost or Server=.) with SQL Authentication enabled
- PowerShell or command prompt
- Visual Studio 2026 (optional; CLI works on any platform)

## Setup (First Time)

### 1. Clone and restore
```powershell
git clone https://github.com/sopheakchea241-ux/PharmacyExtra.git
cd PharmacyExtra.Web
dotnet restore
dotnet build
```

### 2. Configure connection string (User Secrets)
Set up user secrets with your SQL Server credentials:
```powershell
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=.;Database=PharmacyExtra;User Id=sa;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
```

Replace `YOUR_PASSWORD` with your actual SA password.

**Note:** Do not commit secrets to git. User secrets are stored locally in `%APPDATA%\Microsoft\UserSecrets\<UserSecretsId>\secrets.json` and are only loaded during development.

### 3. Run the app
```powershell
dotnet run --project .\PharmacyExtra.Web.csproj
```

The app will:
- Apply pending migrations automatically on startup
- Seed initial data (if configured)
- Listen on https://localhost:5001 and http://localhost:5000

## Project Structure
- **Models/** — EF Core entity classes (scaffolded from PharmacyExtra DB)
- **Migrations/** — EF Core migration history
- **Components/** — Razor components (pages, layouts)
- **Program.cs** — Dependency injection and middleware configuration
- **appsettings.json** — App settings (connection string is empty; secrets are in user-secrets store)

## Database Migrations

### View pending migrations
```powershell
dotnet ef migrations list
```

### Create a new migration
```powershell
dotnet ef migrations add <MigrationName> -o Migrations
```

### Apply migrations
Migrations are applied automatically on app startup via `context.Database.Migrate()` in Program.cs.

To apply manually:
```powershell
dotnet ef database update
```

## Production Deployment
- Store connection strings in secure vaults (Azure Key Vault, AWS Secrets Manager, etc.)
- Use environment variables:
  ```powershell
  $env:ConnectionStrings__DefaultConnection = "Server=prod-server;Database=PharmacyExtra;User Id=sa;Password=...;TrustServerCertificate=False;"
  ```
- Disable developer exception page: `app.UseDeveloperExceptionPage()` only in Development

## CI/CD
- GitHub Actions workflow at `.github/workflows/ci.yml` builds and tests on every push to `main`
- Runs on Windows (dotnet 8.0.x)
- Commands: `dotnet restore`, `dotnet build --configuration Release`

## Troubleshooting

**Q: "The type or namespace name 'Models' does not exist"**
A: Ensure user secrets are initialized and the connection string is set. Run `dotnet user-secrets list` to verify.

**Q: "Database connection failed"**
A: Verify SQL Server is running, SA account is enabled, and the connection string is correct in user secrets.

**Q: Migrations not applying**
A: Check Program.cs — ensure `context.Database.Migrate()` is called on startup. Review logs for errors.

## Resources
- [EF Core Docs](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)
- [User Secrets in .NET](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)
