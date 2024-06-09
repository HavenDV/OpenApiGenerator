﻿//HintName: G.Models.PullsCreateReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsCreateReviewRequest
    {
        /// <summary>
        /// The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// **Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PullsCreateReviewRequestEventJsonConverter))]
        public PullsCreateReviewRequestEvent? Event { get; set; }

        /// <summary>
        /// Use the following table to specify the location, destination, and contents of the draft review comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<PullsCreateReviewRequestComments?>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}