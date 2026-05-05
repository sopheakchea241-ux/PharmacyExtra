# 04-sqlclient-modernization: Migrate System.Data.SqlClient to Microsoft.Data.SqlClient

Replace System.Data.SqlClient package/namespace usage with Microsoft.Data.SqlClient and apply required connection-string/runtime compatibility updates.

**Done when**: System.Data.SqlClient usage is removed, Microsoft.Data.SqlClient is used, and project builds/tests pass for SQL access paths.

## Discovery Notes

- No explicit `System.Data.SqlClient` package references were found in `PharmacyExtra.Web.csproj`.
- No explicit `System.Data.SqlClient` namespace usages were found in source/config files.
- No explicit `Microsoft.Data.SqlClient` namespace usages were found in source/config files either; SQL access is via EF Core `UseSqlServer` provider.
- Search was executed across `*.cs`, `*.csproj`, `*.json`, and `*.config` files while excluding `bin/` and `obj/` artifacts.
- `appsettings.json` contains `ConnectionStrings:DefaultConnection` as empty value; no in-repo connection string needed conversion.

## Execution Plan

1. Keep package/code unchanged (no explicit SqlClient migration surface present).
2. Generate migration report documenting no-op outcome and connection-string review scope.
3. Build solution to validate final state.
