﻿//HintName: G.Models.UpdateConduitShardsResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseData
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  
        ///   
        /// * enabled — The shard is enabled.
        /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.
        /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.
        /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.
        /// * websocket\_disconnected — The client closed the connection.
        /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.
        /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).
        /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.
        /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.
        /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public UpdateConduitShardsResponseDataStatus Status { get; set; } = default!;

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public UpdateConduitShardsResponseDataTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}