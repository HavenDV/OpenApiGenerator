﻿//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlertExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert.Write,
                _ => null,
            };
        }
    }
}