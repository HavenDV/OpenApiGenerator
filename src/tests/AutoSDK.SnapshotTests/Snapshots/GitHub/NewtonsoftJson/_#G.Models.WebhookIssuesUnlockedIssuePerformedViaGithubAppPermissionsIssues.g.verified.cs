﻿//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}