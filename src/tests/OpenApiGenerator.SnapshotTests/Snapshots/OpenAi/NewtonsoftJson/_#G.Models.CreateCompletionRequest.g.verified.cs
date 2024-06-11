﻿//HintName: G.Models.CreateCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCompletionRequest
    {
        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.AnyOf<string, global::G.CreateCompletionRequestModel> Model { get; set; } = default!;

        /// <summary>
        /// The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.
        /// Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document.
        /// <br/>Default Value: &lt;|endoftext|&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Prompt { get; set; } = default!;

        /// <summary>
        /// Generates `best_of` completions server-side and returns the "best" (the one with the highest log probability per token). Results cannot be streamed.
        /// When used with `n`, `best_of` controls the number of candidate completions and `n` specifies how many to return – `best_of` must be greater than `n`.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// <br/>Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("best_of")]
        public int? BestOf { get; set; } = 1;

        /// <summary>
        /// Echo back the prompt in addition to the completion
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("echo")]
        public bool? Echo { get; set; } = false;

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// [See more information about frequency and presence penalties.](/docs/guides/text-generation/parameter-details)
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; } = 0;

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// Accepts a JSON object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this [tokenizer tool](/tokenizer?view=bpe) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.
        /// As an example, you can pass `{"50256": -100}` to prevent the &lt;|endoftext|&gt; token from being generated.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logit_bias")]
        public object? LogitBias { get; set; }

        /// <summary>
        /// Include the log probabilities on the `logprobs` most likely output tokens, as well the chosen tokens. For example, if `logprobs` is 5, the API will return a list of the 5 most likely tokens. The API will always return the `logprob` of the sampled token, so there may be up to `logprobs+1` elements in the response.
        /// The maximum value for `logprobs` is 5.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public int? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of [tokens](/tokenizer) that can be generated in the completion.
        /// The token count of your prompt plus `max_tokens` cannot exceed the model's context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.
        /// <br/>Default Value: 16
        /// <br/>Example: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; } = 16;

        /// <summary>
        /// How many completions to generate for each prompt.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.
        /// [See more information about frequency and presence penalties.](/docs/guides/text-generation/parameter-details)
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; } = 0;

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::System.OneOf<string?, global::System.Collections.Generic.IList<string?>?>? Stop { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; } = false;

        /// <summary>
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_options")]
        public global::G.ChatCompletionStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The suffix that comes after a completion of inserted text.
        /// This parameter is only supported for `gpt-3.5-turbo-instruct`.
        /// <br/>Default Value: 
        /// <br/>Example: test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// We generally recommend altering this or `top_p` but not both.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; } = 1;

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        /// We generally recommend altering this or `temperature` but not both.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; } = 1;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// <br/>Example: user-1234
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}