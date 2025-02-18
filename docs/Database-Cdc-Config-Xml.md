# 'Cdc' object (database-driven) - XML

The `Cdc` object enables the definition of the primary table, one-or-more child tables and their relationships, to enable Change Data Capture (CDC) event publishing. The `IncludeColumns` and `ExcludeColumns` provide a shorthand to include or exclude selected columns; with the `AliasColumns` providing a means to rename where required.

<br/>

## Property categories
The `Cdc` object supports a number of properties that control the generated code output. These properties are separated into a series of logical categories. The properties with a bold name are those that are more typically used (considered more important).

Category | Description
-|-
[`Key`](#Key) | Provides the _key_ configuration.
[`Columns`](#Columns) | Provides the _Columns_ configuration.
[`Database`](#Database) | Provides the _database_ configuration.
[`DotNet`](#DotNet) | Provides the _.NET_ configuration.
[`Infer`](#Infer) | Provides the _special Column Name inference_ configuration.
[`IdentifierMapping`](#IdentifierMapping) | Provides the _identifier mapping_ configuration.
[`Collections`](#Collections) | Provides related child (hierarchical) configuration.

<br/>

## Key
Provides the _key_ configuration.

Property | Description
-|-
**`Name`** | The name of the primary table.
`Schema` | The default schema name used where not otherwise explicitly specified. Defaults to `CodeGeneration.Schema`.
`Alias` | The `Schema.Table` alias name. Will automatically default where not specified.

<br/>

## Columns
Provides the _Columns_ configuration.

Property | Description
-|-
**`IncludeColumns`** | The list of `Column` names to be included in the underlying generated output. Where not specified this indicates that all `Columns` are to be included.
**`ExcludeColumns`** | The list of `Column` names to be excluded from the underlying generated output. Where not specified this indicates no `Columns` are to be excluded.
**`AliasColumns`** | The list of `Column` and `Alias` pairs (split by a `^` lookup character) to enable column aliasing/renaming. Each alias value should be formatted as `Column` + `^` + `Alias`; e.g. `PCODE^ProductCode`.

<br/>

## Database
Provides the _database_ configuration.

Property | Description
-|-
`ExecuteStoredProcedureName` | The `CDC` _execute_ outbox stored procedure name. Defaults to `spExecute` (literal) + `Name` + `CdcOutbox` (literal); e.g. `spExecuteTableNameCdcOutbox`.
`CompleteStoredProcedureName` | The `CDC` _complete_ outbox stored procedure name. Defaults to `spComplete` (literal) + `Name` + `CdcOutbox` (literal); e.g. `spCompleteTableNameCdcOutbox`.
`CdcSchema` | The schema name for the generated `CDC`-related database artefacts. Defaults to `CodeGeneration.CdcSchema`.
`OutboxTableName` | The corresponding `CDC` Outbox table name. Defaults to `Name` + `Outbox` (literal).

<br/>

## DotNet
Provides the _.NET_ configuration.

Property | Description
-|-
`ModelName` | The .NET model name. Defaults to `Name`.
`DataConstructor` | The access modifier for the generated CDC `Data` constructor. Valid options are: `Public`, `Private`, `Protected`. Defaults to `Public`.
`DatabaseName` | The .NET database interface name. Defaults to `IDatabase`.
`EventSubject` | The Event Subject. Defaults to `ModelName`. Note: when used in code-generation the `CodeGeneration.EventSubjectRoot` will be prepended where specified.
`IncludeColumnsOnDelete` | The list of `Column` names that should be included (in addition to the primary key) for a logical delete. Where a column is not specified in this list its corresponding .NET property will be automatically cleared by the `CdcDataOrchestrator` as the data is technically considered as non-existing.
**`ExcludeHostedService`** | The option to exclude the generation of the `CdcHostedService` (background) class (`XxxHostedService.cs`).
`ExcludeColumnsFromETag` | The list of `Column` names that should be excluded from the generated ETag (used for the likes of duplicate send tracking). Defaults to `CodeGeneration.CdcExcludeColumnsFromETag`.

<br/>

## Infer
Provides the _special Column Name inference_ configuration.

Property | Description
-|-
`ColumnNameIsDeleted` | The column name for the `IsDeleted` capability. Defaults to `CodeGeneration.IsDeleted`.

<br/>

## IdentifierMapping
Provides the _identifier mapping_ configuration.

Property | Description
-|-
**`IdentifierMapping`** | Indicates whether to perform Identifier Mapping (mapping to `GlobalId`) for the primary key. This indicates whether to create a new `GlobalId` property on the _entity_ to house the global mapping identifier to be the reference outside of the specific database realm as a replacement to the existing primary key column(s).
**`IdentifierMappingColumns`** | The list of `Column` with related `Schema`/`Table` values (all split by a `^` lookup character) to enable column one-to-one identifier mapping. Each value is formatted as `Column` + `^` + `Schema` + `^` + `Table` where the schema is optional; e.g. `ContactId^dbo^Contact` or `ContactId^Contact`.

<br/>

## Collections
Provides related child (hierarchical) configuration.

Property | Description
-|-
**`Joins`** | The corresponding [`CdcJoin`](Database-CdcJoin-Config-Xml.md) collection. A `Join` object provides the configuration for a joining table.

<br/>

<sub><sup>Note: This markdown file is generated; any changes will be lost.</sup></sub>
