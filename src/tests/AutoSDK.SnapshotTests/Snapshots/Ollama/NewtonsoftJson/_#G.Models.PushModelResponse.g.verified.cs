﻿//HintName: G.Models.PushModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for pushing a model.
    /// </summary>
    public sealed partial class PushModelResponse
    {
        /// <summary>
        /// Status pushing the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PushModelStatus? Status { get; set; }

        /// <summary>
        /// the model's digest<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// total size of the model<br/>
        /// Example: 2142590208L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// Total bytes transferred.<br/>
        /// Example: 2142590208L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public long? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}