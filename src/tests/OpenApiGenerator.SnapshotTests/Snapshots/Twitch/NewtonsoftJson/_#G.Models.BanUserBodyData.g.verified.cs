﻿//HintName: G.Models.BanUserBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies the user and type of ban.
    /// </summary>
    public sealed partial class BanUserBodyData
    {
        /// <summary>
        /// The ID of the user to ban or put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// To ban a user indefinitely, don’t include this field.  <br/>
        ///   <br/>
        /// To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).  <br/>
        ///   <br/>
        /// To end a user’s timeout early, set this field to 1, or use the [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user) endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}