﻿//HintName: G.Models.WebhookIssuesEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the issue.
    /// </summary>
    public sealed partial class WebhookIssuesEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.WebhookIssuesEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public global::G.WebhookIssuesEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}