# System.Data.SqlClient to Microsoft.Data.SqlClient Migration Report

## Scope

Solution: `PharmacyExtra.Web.slnx`

## Dependency Changes

No dependency changes were required.

- `System.Data.SqlClient` package reference: **not present** in project file.
- `System.Data.SqlClient` assembly references: **none found**.
- `Microsoft.Data.SqlClient` direct package reference: **not required** for current code paths (SQL access is through EF Core SQL Server provider).

## Code File Changes

No application code files required namespace/API migration.

Search validated across source/config files (`*.cs`, `*.csproj`, `*.json`, `*.config`) excluding build artifacts (`bin/`, `obj/`) for:
- `System.Data.SqlClient`
- `using System.Data.SqlClient`
- `Microsoft.Data.SqlClient`
- `using Microsoft.Data.SqlClient`
- `SqlConnectionStringBuilder`, `SqlConnection`, `SqlCommand`, `SqlDataReader`

Result: no explicit SqlClient namespace/API usages found in the codebase.

## Connection String Validation

Reviewed in-repo configuration files:
- `appsettings.json`
- `appsettings.Development.json`

Findings:
- In-repo `ConnectionStrings:DefaultConnection` is empty in `appsettings.json`.
- No repository-stored connection string required migration.
- Runtime/user-secrets connection strings should explicitly set `Encrypt` and `TrustServerCertificate` based on environment requirements.

## Unsupported / Manual Patterns

None identified for this repository because there is no explicit `System.Data.SqlClient` usage to convert.

## Behavioral Changes Requiring Runtime Validation

No direct runtime behavior change from SqlClient namespace migration applies (no direct SqlClient API usage exists).

Operational note for externally provided connection strings:
- If a direct `Microsoft.Data.SqlClient` migration is introduced in future code, validate encryption-related settings (`Encrypt`, `TrustServerCertificate`) explicitly to avoid environment-specific connection issues.

## Follow-up Actions

- Continue using EF Core SQL Server provider for data access.
- If future features add direct SQL client usage, use `Microsoft.Data.SqlClient` APIs by default and revisit this migration report.
