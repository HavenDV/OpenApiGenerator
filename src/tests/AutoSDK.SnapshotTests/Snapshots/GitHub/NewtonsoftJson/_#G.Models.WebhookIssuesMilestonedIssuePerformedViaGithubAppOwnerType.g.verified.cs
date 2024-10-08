﻿//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesMilestonedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}