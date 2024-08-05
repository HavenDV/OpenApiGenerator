﻿//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1Action.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="review_requested")]
        ReviewRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1Action value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1Action.ReviewRequested => "review_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "review_requested" => WebhookPullRequestReviewRequestedVariant1Action.ReviewRequested,
                _ => null,
            };
        }
    }
}