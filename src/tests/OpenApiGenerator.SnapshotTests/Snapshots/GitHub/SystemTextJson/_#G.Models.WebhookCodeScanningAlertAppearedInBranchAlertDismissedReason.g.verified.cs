﻿//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    public abstract class WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string FalsePositive = "false positive";
        /// <summary>
        /// 
        /// </summary>
        public const string WontFix = "won't fix";
        /// <summary>
        /// 
        /// </summary>
        public const string UsedInTests = "used in tests";
    }
}