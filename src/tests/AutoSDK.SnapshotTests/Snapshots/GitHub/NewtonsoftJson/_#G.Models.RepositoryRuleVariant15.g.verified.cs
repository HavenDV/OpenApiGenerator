﻿//HintName: G.Models.RepositoryRuleVariant15.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: file_path_restriction is in beta and subject to change.<br/>
    /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
    /// </summary>
    public sealed partial class RepositoryRuleVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleVariant15Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleVariant15Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}