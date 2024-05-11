﻿//HintName: G.Models.GenerateEmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returns the embedding information.
    /// </summary>
    public sealed partial class GenerateEmbeddingResponse
    {
        /// <summary>
        /// The embedding for the prompt.
        /// <br/>Example: [0.5670403838157654, 0.009260174818336964, ...]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}