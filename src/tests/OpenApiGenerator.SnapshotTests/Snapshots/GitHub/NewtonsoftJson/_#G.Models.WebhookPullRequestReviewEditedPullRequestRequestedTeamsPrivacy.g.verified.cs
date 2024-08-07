﻿//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewEditedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}