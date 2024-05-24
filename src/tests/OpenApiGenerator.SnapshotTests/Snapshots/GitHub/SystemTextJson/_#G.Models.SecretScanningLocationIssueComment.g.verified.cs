﻿//HintName: G.Models.SecretScanningLocationIssueComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an 'issue_comment' secret scanning location type. This location type shows that a secret was detected in a comment on an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueComment
    {
        /// <summary>
        /// The API URL to get the issue comment where the secret was detected.
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/issues/comments/1081119451
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}