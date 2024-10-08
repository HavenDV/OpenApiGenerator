﻿//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertReopenedAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAlertState.Open => "open",
                WebhookCodeScanningAlertReopenedAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedAlertState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAlertState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertReopenedAlertState.Open,
                "dismissed" => WebhookCodeScanningAlertReopenedAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedAlertState.Fixed,
                _ => null,
            };
        }
    }
}