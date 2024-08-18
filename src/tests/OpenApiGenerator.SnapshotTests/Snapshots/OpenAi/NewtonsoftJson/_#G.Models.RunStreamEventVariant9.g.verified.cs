﻿//HintName: G.Models.RunStreamEventVariant9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run](/docs/api-reference/runs/object) is cancelled.
    /// </summary>
    public sealed partial class RunStreamEventVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.RunStreamEventVariant9Event Event { get; set; }

        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}