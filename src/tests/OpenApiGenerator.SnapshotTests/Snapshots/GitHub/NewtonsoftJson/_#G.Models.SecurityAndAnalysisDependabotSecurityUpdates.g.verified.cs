﻿//HintName: G.Models.SecurityAndAnalysisDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enable or disable Dependabot security updates for the repository.
    /// </summary>
    public sealed partial class SecurityAndAnalysisDependabotSecurityUpdates
    {
        /// <summary>
        /// The enablement status of Dependabot security updates for the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public SecurityAndAnalysisDependabotSecurityUpdatesStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}