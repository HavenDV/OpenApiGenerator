﻿//HintName: G.Models.WebhooksRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The branch protection rule. Includes a `name` and all the [branch protection settings](https://docs.github.com/github/administering-a-repository/defining-the-mergeability-of-pull-requests/about-protected-branches#about-branch-protection-settings) applied to branches that match the name. Binary settings are boolean. Multi-level configurations are one of `off`, `non_admins`, or `everyone`. Actor and build lists are arrays of strings.
    /// </summary>
    public sealed partial class WebhooksRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_enforced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AdminEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_deletions_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleAllowDeletionsEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleAllowDeletionsEnforcementLevel AllowDeletionsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_force_pushes_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleAllowForcePushesEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleAllowForcePushesEnforcementLevel AllowForcePushesEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actor_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AuthorizedActorNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actors_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AuthorizedActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_dismissal_actors_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AuthorizedDismissalActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_protected")]
        public bool? CreateProtected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_stale_reviews_on_push")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DismissStaleReviewsOnPush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_approvals_from_contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IgnoreApprovalsFromContributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_history_requirement_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleLinearHistoryRequirementEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleLinearHistoryRequirementEnforcementLevel LinearHistoryRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_queue_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleMergeQueueEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleMergeQueueEnforcementLevel MergeQueueEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_reviews_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRulePullRequestReviewsEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRulePullRequestReviewsEnforcementLevel PullRequestReviewsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_code_owner_review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireCodeOwnerReview { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_conversation_resolution_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleRequiredConversationResolutionLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleRequiredConversationResolutionLevel RequiredConversationResolutionLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_deployments_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleRequiredDeploymentsEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleRequiredDeploymentsEnforcementLevel RequiredDeploymentsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleRequiredStatusChecksEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel RequiredStatusChecksEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature_requirement_enforcement_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRuleSignatureRequirementEnforcementLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRuleSignatureRequirementEnforcementLevel SignatureRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_required_status_checks_policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StrictRequiredStatusChecksPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}