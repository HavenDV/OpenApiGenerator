﻿//HintName: G.Models.Activity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Activity
    /// </summary>
    public sealed partial class Activity
    {
        /// <summary>
        /// <br/>Example: 1296269
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit before the activity.
        /// <br/>Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before", Required = global::Newtonsoft.Json.Required.Always)]
        public string Before { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit after the activity.
        /// <br/>Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after", Required = global::Newtonsoft.Json.Required.Always)]
        public string After { get; set; } = default!;

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.
        /// <br/>Example: refs/heads/main
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// The time when the activity occurred.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// The type of the activity that was performed.
        /// <br/>Example: force_push
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("activity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public ActivityActivityType ActivityType { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Actor { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}