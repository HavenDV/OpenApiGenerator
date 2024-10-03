﻿//HintName: G.Models.JobsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsOut
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.JobOut>? Data { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.JobsOutObject? Object { get; set; } = global::G.JobsOutObject.List;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}