﻿//HintName: G.Models.WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails
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
    public static class WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmailsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails.Read => "read",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails.Read,
                "write" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsEmails.Write,
                _ => null,
            };
        }
    }
}