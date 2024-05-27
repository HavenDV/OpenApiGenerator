﻿//HintName: G.Models.CreatePredictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionsRequest
    {
        /// <summary>
        /// The model's input as a JSON object. The input schema depends on what model you are running. To see the available inputs, click the "API" tab on the model you are running or [get the model version](#models.versions.get) and look at its `openapi_schema` property. For example, [stability-ai/sdxl](https://replicate.com/stability-ai/sdxl) takes `prompt` as an input.
        /// Files should be passed as HTTP URLs or data URLs.
        /// Use an HTTP URL when:
        /// - you have a large file &gt; 256kb
        /// - you want to be able to use the file multiple times
        /// - you want your prediction metadata to be associable with your input files
        /// Use a data URL when:
        /// - you have a small file &lt;= 256kb
        /// - you don't want to upload and host the file somewhere
        /// - you don't need to use the file again (Replicate will not store it)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Request a URL to receive streaming output using [server-sent events (SSE)](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events).
        /// If the requested model version supports streaming, the returned prediction will have a `stream` entry in its `urls` property with an HTTPS URL that you can use to construct an [`EventSource`](https://developer.mozilla.org/en-US/docs/Web/API/EventSource).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool Stream { get; set; }

        /// <summary>
        /// The ID of the model version that you want to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// An HTTPS URL for receiving a webhook when the prediction has new output. The webhook will be a POST request where the request body is the same as the response body of the [get prediction](#predictions.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the prediction has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the prediction request:
        /// - `start`: immediately on prediction start
        /// - `output`: each time a prediction generates an output (note that predictions can generate multiple outputs)
        /// - `logs`: each time log output is generated by a prediction
        /// - `completed`: when the prediction reaches a terminal state (succeeded/canceled/failed)
        /// For example, if you only wanted requests to be sent at the start and end of the prediction, you would provide:
        /// ```json
        /// {
        ///   "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",
        ///   "input": {
        ///     "text": "Alice"
        ///   },
        ///   "webhook": "https://example.com/my-webhook",
        ///   "webhook_events_filter": ["start", "completed"]
        /// }
        /// ```
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_events_filter")]
        public global::System.Collections.Generic.IList<CreatePredictionsRequestWebhookEventsFilter?>? WebhookEventsFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}