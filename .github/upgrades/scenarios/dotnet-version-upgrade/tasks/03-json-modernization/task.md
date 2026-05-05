# 03-json-modernization: Migrate Newtonsoft.Json usage to System.Text.Json

Find and migrate Newtonsoft.Json usage where applicable, update package references, and adapt serialization/deserialization code paths to System.Text.Json equivalents.

**Done when**: Newtonsoft.Json dependency is removed (or explicitly documented where retention is required), code builds, and impacted JSON flows compile and run.

## Discovery Notes

- `PharmacyExtra.Web.csproj` contains no explicit `Newtonsoft.Json` package or assembly reference.
- No `Directory.Packages.props` or `packages.config` was found in this workspace.
- Workspace code search for Newtonsoft APIs (`Newtonsoft.Json`, `JsonConvert`, `JObject`, `JToken`, `JsonPropertyAttribute`) found no actual Newtonsoft usages requiring conversion.
- Search hits were from model/type names containing `Json` as plain text, not from Newtonsoft API usage.

## Execution Plan

1. Keep project dependencies unchanged for this task (no Newtonsoft reference to remove).
2. Record no-op migration result in the required migration report.
3. Build solution to confirm unchanged compile state.
