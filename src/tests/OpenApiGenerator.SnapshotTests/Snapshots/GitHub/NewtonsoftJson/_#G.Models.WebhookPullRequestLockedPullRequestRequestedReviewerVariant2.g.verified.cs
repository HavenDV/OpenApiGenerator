﻿//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedReviewerVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestRequestedReviewerVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Description of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.WebhookPullRequestLockedPullRequestRequestedReviewerVariant2Parent? Parent { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestLockedPullRequestRequestedReviewerVariant2Privacy Privacy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// URL for the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}