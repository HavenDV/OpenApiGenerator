﻿//HintName: G.Models.GenerateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response class for the chat endpoint.
    /// </summary>
    public sealed partial class GenerateChatCompletionResponse
    {
        /// <summary>
        /// A message in the chat endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public Message? Message { get; set; }

        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Date on which a model was created.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether the response has completed.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done")]
        public bool Done { get; set; }

        /// <summary>
        /// Time spent generating the response.
        /// <br/>Example: 5589157167
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration")]
        public int TotalDuration { get; set; }

        /// <summary>
        /// Time spent in nanoseconds loading the model.
        /// <br/>Example: 3013701500
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("load_duration")]
        public int LoadDuration { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.
        /// <br/>Example: 46
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_count")]
        public int PromptEvalCount { get; set; }

        /// <summary>
        /// Time spent in nanoseconds evaluating the prompt.
        /// <br/>Example: 1160282000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_duration")]
        public int PromptEvalDuration { get; set; }

        /// <summary>
        /// Number of tokens the response.
        /// <br/>Example: 113
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_count")]
        public int EvalCount { get; set; }

        /// <summary>
        /// Time in nanoseconds spent generating the response.
        /// <br/>Example: 1325948000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_duration")]
        public int EvalDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}