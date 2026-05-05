# .NET Version Upgrade

## Strategy
- **Selected**: All-at-Once
- **Rationale**: Single SDK-style Blazor project, low complexity assessment, clear package upgrade recommendations.

## Preferences
- **Flow Mode**: Automatic
- **Commit Strategy**: Single Commit at End
- **Pace**: Standard
- **Source branch**: `main`
- **Working branch**: `upgrade-to-NET10`
- **Pending changes action**: Commit before switching branches
- **Target framework**: `net10.0` (.NET 10.0 LTS)

## Decisions
- Execute modernization items in this order: 1) .NET version upgrade, 2) SDK-style validation/conversion, 3) Newtonsoft.Json → System.Text.Json, 4) System.Data.SqlClient → Microsoft.Data.SqlClient.
- Proceed with automatic flow unless blocked.

## Custom Instructions
- For 01-dotnet10-upgrade: Keep the focus on .NET retargeting and required package/runtime compatibility only.
- For 02-sdk-style-validation: Validate format and only convert if any non-SDK artifact is found.
- For 03-json-modernization: Apply Newtonsoft.Json migration after the framework upgrade is stable.
- For 04-sqlclient-modernization: Apply SqlClient migration after JSON migration completes.