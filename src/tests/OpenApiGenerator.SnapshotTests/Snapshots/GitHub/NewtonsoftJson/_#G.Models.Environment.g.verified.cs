﻿//HintName: G.Models.Environment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a deployment environment
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// The id of the environment.
        /// <br/>Example: 56780428
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the environment.
        /// <br/>Example: staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The time that the environment was created, in ISO 8601 format.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the environment was last updated, in ISO 8601 format.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Built-in deployment protection rules for the environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_rules")]
        public global::System.Collections.Generic.IList<object?>? ProtectionRules { get; set; }

        /// <summary>
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_branch_policy")]
        public DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}