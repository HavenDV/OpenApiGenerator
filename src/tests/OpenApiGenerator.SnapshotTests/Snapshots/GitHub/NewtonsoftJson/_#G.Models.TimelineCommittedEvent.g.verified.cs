﻿//HintName: G.Models.TimelineCommittedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Committed Event
    /// </summary>
    public sealed partial class TimelineCommittedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public string? Event { get; set; }

        /// <summary>
        /// SHA for the commit
        /// <br/>Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Identifying information for the git-user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public TimelineCommittedEventAuthor Author { get; set; } = default!;

        /// <summary>
        /// Identifying information for the git-user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public TimelineCommittedEventCommitter Committer { get; set; } = default!;

        /// <summary>
        /// Message describing the purpose of the commit
        /// <br/>Example: Fix #42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree", Required = global::Newtonsoft.Json.Required.Always)]
        public TimelineCommittedEventTree Tree { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<TimelineCommittedEventParents> Parents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification", Required = global::Newtonsoft.Json.Required.Always)]
        public TimelineCommittedEventVerification Verification { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}