﻿//HintName: G.Models.UpdateConduitShardsBodyShardsTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details that you want Twitch to use when sending you notifications.
    /// </summary>
    public sealed partial class UpdateConduitShardsBodyShardsTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  
        ///   
        /// * webhook
        /// * websocket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UpdateConduitShardsBodyShardsTransportMethodJsonConverter))]
        public global::G.UpdateConduitShardsBodyShardsTransportMethod? Method { get; set; }

        /// <summary>
        /// The callback URL where the notifications are sent. The URL must use the HTTPS protocol and port 443\. See Processing an event.Specify this field only if method is set to webhook.NOTE: Redirects are not followed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// The secret used to verify the signature. The secret must be an ASCII string that’s a minimum of 10 characters long and a maximum of 100 characters long. For information about how the secret is used, see Verifying the event message.Specify this field only if method is set to webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket to send notifications to. When you connect to EventSub using WebSockets, the server returns the ID in the Welcome message.Specify this field only if method is set to websocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}