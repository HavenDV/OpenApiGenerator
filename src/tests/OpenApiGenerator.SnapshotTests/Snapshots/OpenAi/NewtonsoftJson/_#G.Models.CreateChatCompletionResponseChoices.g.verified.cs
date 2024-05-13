﻿//HintName: G.Models.CreateChatCompletionResponseChoices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponseChoices
    {
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
        /// `length` if the maximum number of tokens specified in the request was reached,
        /// `content_filter` if content was omitted due to a flag from our content filters,
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateChatCompletionResponseChoicesFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// The index of the choice in the list of choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// A chat completion message generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public ChatCompletionResponseMessage Message { get; set; } = default!;

        /// <summary>
        /// Log probability information for the choice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateChatCompletionResponseChoicesLogprobs? Logprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}