﻿//HintName: G.Models.BranchProtectionRequiredSignatures.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchProtectionRequiredSignatures
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_signatures
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}