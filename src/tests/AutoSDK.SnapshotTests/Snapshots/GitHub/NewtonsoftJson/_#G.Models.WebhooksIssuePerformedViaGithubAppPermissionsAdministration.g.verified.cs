﻿//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssuePerformedViaGithubAppPermissionsAdministration
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
    public static class WebhooksIssuePerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhooksIssuePerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssuePerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhooksIssuePerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}