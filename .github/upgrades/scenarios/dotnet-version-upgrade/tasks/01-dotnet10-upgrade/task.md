# 01-dotnet10-upgrade: Upgrade project to .NET 10

Retarget the project from net8.0 to net10.0 and apply framework-compatible package updates identified by assessment. Include any required behavioral compatibility fix validation.

**Done when**: Target framework is net10.0, restore/build succeed, and runtime behavior risks identified in assessment are addressed or validated.

## Research Notes

- Project is already SDK-style (`Microsoft.NET.Sdk.Web`) and currently targets `net8.0`.
- Assessment recommends package upgrades for EF Core packages:
  - `Microsoft.EntityFrameworkCore.SqlServer` 8.0.0 → 10.0.7
  - `Microsoft.EntityFrameworkCore.Tools` 8.0.0 → 10.0.7
  - `Microsoft.EntityFrameworkCore.Design` 8.0.0 → 10.0.7
- Assessment detected one behavioral change candidate:
  - `UseExceptionHandler(IApplicationBuilder, string, bool)` behavior change should be validated by build/runtime checks after retarget.
- `Program.cs` currently uses `app.UseExceptionHandler("/Error", createScopeForErrors: true);`.

## Execution Plan

1. Update `PharmacyExtra.Web.csproj` target framework to `net10.0`.
2. Update EF Core package references to `10.0.7`.
3. Restore and build solution.
4. Validate health endpoints and startup pipeline compile cleanly with .NET 10.
5. Capture results in progress detail and complete task.
