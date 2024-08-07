﻿//HintName: G.Models.WebhookPullRequestLabeledPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAssigneesType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestAssigneesType.User => "User",
                WebhookPullRequestLabeledPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}