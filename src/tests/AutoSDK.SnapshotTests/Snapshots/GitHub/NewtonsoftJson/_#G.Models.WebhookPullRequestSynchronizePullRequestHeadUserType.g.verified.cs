﻿//HintName: G.Models.WebhookPullRequestSynchronizePullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestHeadUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestHeadUserType.User => "User",
                WebhookPullRequestSynchronizePullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}