﻿{{! Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef }}
/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Beef;
using Beef.Data.Database;
using Beef.Data.Database.Cdc;
using Beef.Events;
using Beef.Mapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using {{Root.NamespaceCdc}}.Entities;

namespace {{Root.NamespaceCdc}}.Data
{
    /// <summary>
    /// Enables the CDC data access for database object '{{Schema}}.{{Name}}'.
    /// </summary>
    public partial interface I{{ModelName}}CdcData : ICdcDataOrchestrator { }

    /// <summary>
    /// Provides the CDC data access for database object '{{Schema}}.{{Name}}'.
    /// </summary>
    public partial class {{ModelName}}CdcData : CdcDataOrchestrator<{{ModelName}}Cdc, {{ModelName}}CdcData.{{ModelName}}CdcWrapperCollection, {{ModelName}}CdcData.{{ModelName}}CdcWrapper, CdcTrackingDbMapper>, I{{ModelName}}CdcData
    {
        private static readonly DatabaseMapper<{{ModelName}}CdcWrapper> _{{camel ModelName}}CdcWrapperMapper = DatabaseMapper.CreateAuto<{{ModelName}}CdcWrapper>();
{{#each CdcJoins}}
        private static readonly DatabaseMapper<{{Parent.ModelName}}Cdc.{{ModelName}}Cdc> _{{camel ModelName}}CdcMapper = DatabaseMapper.CreateAuto<{{Parent.ModelName}}Cdc.{{ModelName}}Cdc>();
{{/each}}
{{#each DataCtorParameters}}
  {{#if @first}}

  {{/if}}
        private readonly {{Type}} {{PrivateName}};
{{/each}}

        /// <summary>
        /// Initializes a new instance of the <see cref="{{ModelName}}CdcData"/> class.
        /// </summary>
        /// <param name="db">The <see cref="{{DatabaseName}}"/>.</param>
        /// <param name="evtPub">The <see cref="IEventPublisher"/>.</param>
        /// <param name="logger">The <see cref="ILogger"/>.</param>
{{#each DataCtorParameters}}
        /// <param name="{{ArgumentName}}">{{{SummaryText}}}</param>
{{/each}}
        {{lower DataCtor}} {{ModelName}}CdcData({{DatabaseName}} db, IEventPublisher evtPub, ILogger<{{ModelName}}CdcData> logger{{#each DataCtorParameters}}, {{Type}} {{ArgumentName}}{{/each}}) :
            base(db, "[{{CdcSchema}}].[{{StoredProcedureName}}]", evtPub, logger){{#ifeq DataCtorParameters.Count 0}} => {{ModelName}}CdcDataCtor();{{/ifeq}}
{{#ifne DataCtorParameters.Count 0}}
        {
  {{#each DataCtorParameters}}
            {{PrivateName}} = Check.NotNull({{ArgumentName}}, nameof({{ArgumentName}}));
  {{/each}}
            {{ModelName}}CdcDataCtor();
        }
{{/ifne}}

        partial void {{ModelName}}CdcDataCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the outbox entity data from the database.
        /// </summary>
        /// <param name="maxBatchSize">The recommended maximum batch size.</param>
        /// <param name="incomplete">Indicates whether to return the last <b>incomplete</b> outbox where <c>true</c>; othewise, <c>false</c> for the next new outbox.</param>
        /// <returns>The corresponding result.</returns>
        protected override async Task<CdcDataOrchestratorResult<{{ModelName}}CdcWrapperCollection, {{ModelName}}CdcWrapper>> GetOutboxEntityDataAsync(int maxBatchSize, bool incomplete)
        {
            var {{Alias}}Coll = new {{ModelName}}CdcWrapperCollection();

            var result = await SelectQueryMultiSetAsync(maxBatchSize, incomplete,
                new MultiSetCollArgs<{{ModelName}}CdcWrapperCollection, {{ModelName}}CdcWrapper>(_{{camel ModelName}}CdcWrapperMapper, r => {{Alias}}Coll = r, stopOnNull: true){{#ifne CdcJoins.Count 0}},{{/ifne}} // Root table: {{Schema}}.{{Name}}
{{#each CdcJoins}}
                new MultiSetCollArgs<{{Parent.ModelName}}Cdc.{{ModelName}}CdcCollection, {{Parent.ModelName}}Cdc.{{ModelName}}Cdc>(_{{camel ModelName}}CdcMapper, r =>
                {
  {{#each JoinHierarchyReverse}}
                    {{indent IndentIndex}}foreach (var {{Alias}} in {{#if @first}}r{{else}}{{HierarchyChild.Alias}}{{/if}}{{#unless @first}}.Coll{{/unless}}.GroupBy(x => new { {{#each OnSelectColumns}}{{#unless @last}}, {{/unless}}x.{{#if @../../first}}{{Name}}{{else}}{{#if @../last}}{{ToColumn}}{{else}}{{pascal Parent.JoinTo}}_{{Name}}{{/if}}{{/if}}{{/each}} }).Select(g => new { {{#each OnSelectColumns}}{{#unless @last}}, {{/unless}}g.Key.{{#if @../../first}}{{Name}}{{else}}{{#if @../last}}{{ToColumn}}{{else}}{{pascal Parent.JoinTo}}_{{Name}}{{/if}}{{/if}}{{/each}}, Coll = g.{{#if @last}}ToCollection<{{../Parent.ModelName}}Cdc.{{../ModelName}}CdcCollection, {{../Parent.ModelName}}Cdc.{{../ModelName}}Cdc>{{else}}ToList{{/if}}() })) // Join table: {{Name}} ({{Schema}}.{{TableName}})
                   {{indent IndentIndex}} {
    {{#unless @last}}
                   {{indent IndentIndex}}     var {{#ifval HierarchyChild}}{{HierarchyChild.Alias}}{{else}}{{Parent.Alias}}{{/ifval}}Item = {{#ifval HierarchyChild}}{{HierarchyChild.Alias}}{{else}}{{Parent.Alias}}{{/ifval}}Coll.Single(x => {{#each OnSelectColumns}}{{#unless @last}} && {{/unless}}x.{{ToColumn}} == {{Parent.Alias}}.{{#if @../last}}{{ToColumn}}{{else}}{{pascal Parent.JoinTo}}_{{Name}}{{/if}}{{/each}}).{{PropertyName}};
    {{else}}
                   {{indent IndentIndex}}     {{#if @first}}{{Parent.Alias}}Coll{{else}}{{#ifnull HierarchyChild.HierarchyChild}}{{Parent.Alias}}{{else}}HierarchyChild.HierarchyChild.Alias{{/ifnull}}Item{{/if}}.Single(x => {{#each OnSelectColumns}}{{#unless @last}} && {{/unless}}x.{{ToColumn}} == {{Parent.Alias}}.{{#if @../../first}}{{Name}}{{else}}{{#if @../last}}{{ToColumn}}{{else}}{{pascal Parent.JoinTo}}_{{Name}}{{/if}}{{/if}}{{/each}}).{{PropertyName}} = {{Alias}}.Coll{{#ifeq JoinCardinality 'OneToOne'}}.SingleOrDefault(){{/ifeq}};
    {{/unless}}
  {{/each}}
  {{#each JoinHierarchy}}
                   {{indent IndentIndex}} }
  {{/each}}
                }){{#unless @last}},{{/unless}} // Related table: {{Name}} ({{Schema}}.{{TableName}})
{{/each}}
                ).ConfigureAwait(false);

            result.Result.AddRange({{Alias}}Coll);
            return result;
        }

        /// <summary>
        /// Gets the <see cref="EventData.Subject"/> without the appended key value(s).
        /// </summary>
        protected override string EventSubject => "{{#ifval Root.EventSubjectRoot}}{{Root.EventSubjectRoot}}.{{/ifval}}{{EventSubject}}";

        /// <summary>
        /// Gets the <see cref="Events.EventActionFormat"/>.
        /// </summary>
        protected override EventActionFormat EventActionFormat => EventActionFormat.{{Root.EventActionFormat}};

        /// <summary>
        /// Represents a <see cref="{{ModelName}}Cdc"/> wrapper to append the required (additional) database properties.
        /// </summary>
        public class {{ModelName}}CdcWrapper : {{ModelName}}Cdc, ICdcWrapper
        {
            /// <summary>
            /// Gets or sets the database CDC <see cref="OperationType"/>.
            /// </summary>
            [MapperProperty("_OperationType", ConverterType = typeof(CdcOperationTypeConverter))]
            public OperationType DatabaseOperationType { get; set; }

            /// <summary>
            /// Gets or sets the database tracking hash code.
            /// </summary>
            [MapperProperty("_TrackingHash")]
            public string? DatabaseTrackingHash { get; set; }
        }

        /// <summary>
        /// Represents a <see cref="{{ModelName}}CdcWrapper"/> collection.
        /// </summary>
        public class {{ModelName}}CdcWrapperCollection : List<{{ModelName}}CdcWrapper> { }
    }
}

#pragma warning restore
#nullable restore