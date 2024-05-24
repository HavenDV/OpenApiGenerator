﻿//HintName: G.Models.WebhookCodeScanningAlertReopenedByUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookCodeScanningAlertReopenedByUserAction Action { get; set; } = default!;

        /// <summary>
        /// The code scanning alert involved in the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookCodeScanningAlertReopenedByUserAlert Alert { get; set; } = default!;

        /// <summary>
        /// The commit SHA of the code scanning alert. When the action is `reopened_by_user` or `closed_by_user`, the event was triggered by the `sender` and this value will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_oid", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitOid { get; set; } = default!;

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured
        /// for and sent to a GitHub App. For more information,
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The Git reference of the code scanning alert. When the action is `reopened_by_user` or `closed_by_user`, the event was triggered by the `sender` and this value will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryWebhooks Repository { get; set; } = default!;

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public SimpleUserWebhooks Sender { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}