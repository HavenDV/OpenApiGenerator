﻿//HintName: G.Models.GetModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains information about the model and which API endpoints it can be used with.
    /// </summary>
    public sealed partial class GetModelResponse
    {
        /// <summary>
        /// Specify this name in the `model` parameter of API requests to use your chosen model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The API endpoints that the model is compatible with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? Endpoints { get; set; }

        /// <summary>
        /// Whether the model has been fine-tuned or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned")]
        public bool? Finetuned { get; set; }

        /// <summary>
        /// The maximum number of tokens that the model can process in a single request. Note that not all of these tokens are always available due to special tokens and preambles that Cohere has added by default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_length")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// Public URL to the tokenizer's configuration file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer_url")]
        public string? TokenizerUrl { get; set; }

        /// <summary>
        /// The API endpoints that the model is default to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? DefaultEndpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}