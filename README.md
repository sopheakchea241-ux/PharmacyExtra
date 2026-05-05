# PharmacyExtra

ASP.NET Core Razor Components project with EF Core models scaffolded from an existing SQL Server database.

Prerequisites
- .NET 8 SDK
- SQL Server accessible at Server=. with SQL auth (sa / 123456) or update appsettings.json
- PowerShell (recommended) or command prompt

Quick start
1. Clone repo
   git clone https://github.com/sopheakchea241-ux/PharmacyExtra.git
2. Open the solution in Visual Studio 2026 or use CLI
   dotnet restore
   dotnet build
3. Run the app
   dotnet run --project PharmacyExtra.Web.csproj

Scaffolding and Migrations
- Models and migrations live in the PharmacyExtra.Data project.
- To add migrations from the root, run:
  dotnet ef migrations add <Name> -p PharmacyExtra.Data.csproj -s PharmacyExtra.Web.csproj -o Migrations
- To apply migrations at runtime the app will call Database.Migrate() on startup.

Notes
- Connection string is in appsettings.json (DefaultConnection). Move secrets to user secrets or environment variables in production.
- Generated model classes have nullable annotations; review and adjust as needed.

CI
- GitHub Actions workflow at .github/workflows/ci.yml builds the project on push to main.
