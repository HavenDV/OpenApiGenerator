﻿//HintName: G.Models.CreateEmbeddingResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The usage information for the request.
    /// </summary>
    public sealed partial class CreateEmbeddingResponseUsage
    {
        /// <summary>
        /// The number of tokens used by the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// The total number of tokens used by the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}