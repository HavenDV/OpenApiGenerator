﻿//HintName: G.Models.PullModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for pulling a model.
    /// </summary>
    public sealed partial class PullModelRequest
    {
        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Allow insecure connections to the library. 
        /// Only use this if you are pulling from your own library during development.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insecure")]
        public bool Insecure { get; set; } = false;

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; } = false;

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}