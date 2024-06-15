﻿//HintName: G.Models.ProcessResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for the list running models endpoint.
    /// </summary>
    public sealed partial class ProcessResponse
    {
        /// <summary>
        /// List of running models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::System.Collections.Generic.IList<global::G.ProcessModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}