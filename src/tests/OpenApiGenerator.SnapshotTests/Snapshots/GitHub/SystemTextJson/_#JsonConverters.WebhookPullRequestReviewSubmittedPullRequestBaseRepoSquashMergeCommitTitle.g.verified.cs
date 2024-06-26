﻿//HintName: JsonConverters.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitle.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitle Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookPullRequestReviewSubmittedPullRequestBaseRepoSquashMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
