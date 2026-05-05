# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade the Blazor web project to .NET 10 and then execute the requested modernization items in order.
**Scope**: Single ASP.NET Core Blazor project with straightforward framework and package upgrades.

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: 1 project, currently on net8.0, SDK-style already enabled, and assessment indicates low complexity with clear package upgrade paths.

## Tasks

### 01-dotnet10-upgrade: Upgrade project to .NET 10

Retarget the project from net8.0 to net10.0 and apply framework-compatible package updates identified by assessment. Include any required behavioral compatibility fix validation.

**Done when**: Target framework is net10.0, restore/build succeed, and runtime behavior risks identified in assessment are addressed or validated.

---

### 02-sdk-style-validation: Validate SDK-style project format

Validate SDK-style compatibility and ensure no legacy project-format remnants or related upgrade blockers remain after the target framework change.

**Done when**: Project remains SDK-style and builds cleanly without legacy format blockers.

---

### 03-json-modernization: Migrate Newtonsoft.Json usage to System.Text.Json

Find and migrate Newtonsoft.Json usage where applicable, update package references, and adapt serialization/deserialization code paths to System.Text.Json equivalents.

**Done when**: Newtonsoft.Json dependency is removed (or explicitly documented where retention is required), code builds, and impacted JSON flows compile and run.

---

### 04-sqlclient-modernization: Migrate System.Data.SqlClient to Microsoft.Data.SqlClient

Replace System.Data.SqlClient package/namespace usage with Microsoft.Data.SqlClient and apply required connection-string/runtime compatibility updates.

**Done when**: System.Data.SqlClient usage is removed, Microsoft.Data.SqlClient is used, and project builds/tests pass for SQL access paths.