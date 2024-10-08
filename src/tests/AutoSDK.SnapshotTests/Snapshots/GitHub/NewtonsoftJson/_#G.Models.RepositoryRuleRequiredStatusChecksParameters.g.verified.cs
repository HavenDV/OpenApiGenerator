﻿//HintName: G.Models.RepositoryRuleRequiredStatusChecksParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleRequiredStatusChecksParameters
    {
        /// <summary>
        /// Status checks that are required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsStatusCheckConfiguration> RequiredStatusChecks { get; set; } = default!;

        /// <summary>
        /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict_required_status_checks_policy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StrictRequiredStatusChecksPolicy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}