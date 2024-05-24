﻿//HintName: G.Models.OrganizationProgrammaticAccessGrant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Minimal representation of an organization programmatic access grant for enumerations
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrant
    {
        /// <summary>
        /// Unique identifier of the fine-grained personal access token. The `pat_id` used to get details about an approved fine-grained personal access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationProgrammaticAccessGrantRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Permissions requested, categorized by type of permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationProgrammaticAccessGrantPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Date and time when the fine-grained personal access token was approved to access the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_granted_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessGrantedAt { get; set; } = default!;

        /// <summary>
        /// Whether the associated fine-grained personal access token has expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expired", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TokenExpired { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenExpiresAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenLastUsedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}