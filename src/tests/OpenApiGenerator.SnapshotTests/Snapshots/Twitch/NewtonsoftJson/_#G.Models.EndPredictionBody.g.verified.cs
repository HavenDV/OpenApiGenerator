﻿//HintName: G.Models.EndPredictionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndPredictionBody
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The ID of the prediction to update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status to set the prediction to. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.<br/>
        /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.<br/>
        /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.<br/>
        ///   <br/>
        /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  <br/>
        ///   <br/>
        /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EndPredictionBodyStatus Status { get; set; } = default!;

        /// <summary>
        /// The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("winning_outcome_id")]
        public string? WinningOutcomeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}