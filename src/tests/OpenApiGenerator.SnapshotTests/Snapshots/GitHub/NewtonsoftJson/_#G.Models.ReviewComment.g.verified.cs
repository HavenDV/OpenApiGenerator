﻿//HintName: G.Models.ReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Legacy Review Comment
    /// </summary>
    public sealed partial class ReviewComment
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? PullRequestReviewId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_hunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffHunk { get; set; } = default!;

        /// <summary>
        /// <br/>Example: file1.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Position { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_position", Required = global::Newtonsoft.Json.Required.Always)]
        public int OriginalPosition { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalCommitId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_reply_to_id")]
        public int InReplyToId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Great stuff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// <br/>Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public ReviewCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public ReviewCommentLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// <br/>Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side")]
        public ReviewCommentSide? Side { get; set; } = ReviewCommentSide.RIGHT;

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// <br/>Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_side")]
        public ReviewCommentStartSide? StartSide { get; set; } = ReviewCommentStartSide.RIGHT;

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// The original line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_line")]
        public int OriginalLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The original first line of the range for a multi-line comment.
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}