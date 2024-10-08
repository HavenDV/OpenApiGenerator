﻿//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlertExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert.Write,
                _ => null,
            };
        }
    }
}