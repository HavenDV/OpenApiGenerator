﻿//HintName: G.Models.WebhookBranchProtectionRuleEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If the action was `edited`, the changes to the rule.
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_enforced")]
        public WebhookBranchProtectionRuleEditedChangesAdminEnforced? AdminEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actor_names")]
        public WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? AuthorizedActorNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actors_only")]
        public WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? AuthorizedActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_dismissal_actors_only")]
        public WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? AuthorizedDismissalActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_history_requirement_enforcement_level")]
        public WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? LinearHistoryRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks_enforcement_level")]
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? RequiredStatusChecksEnforcementLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}