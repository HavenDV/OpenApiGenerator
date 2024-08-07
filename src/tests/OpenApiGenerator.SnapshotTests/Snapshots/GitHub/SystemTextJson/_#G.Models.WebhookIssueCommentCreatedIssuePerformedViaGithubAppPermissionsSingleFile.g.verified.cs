﻿//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}