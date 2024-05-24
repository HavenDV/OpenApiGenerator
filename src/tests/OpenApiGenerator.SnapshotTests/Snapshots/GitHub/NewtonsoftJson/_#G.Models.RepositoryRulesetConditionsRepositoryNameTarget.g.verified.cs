﻿//HintName: G.Models.RepositoryRulesetConditionsRepositoryNameTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a repository name condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryNameTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_name", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRulesetConditionsRepositoryNameTargetRepositoryName RepositoryName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}