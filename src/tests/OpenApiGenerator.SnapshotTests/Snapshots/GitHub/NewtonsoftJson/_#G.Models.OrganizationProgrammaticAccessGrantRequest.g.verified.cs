﻿//HintName: G.Models.OrganizationProgrammaticAccessGrantRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Minimal representation of an organization programmatic access grant request for enumerations
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrantRequest
    {
        /// <summary>
        /// Unique identifier of the request for access via fine-grained personal access token. The `pat_request_id` used to review PAT requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Reason for requesting access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Reason { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationProgrammaticAccessGrantRequestRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// URL to the list of repositories requested to be accessed via fine-grained personal access token. Should only be followed when `repository_selection` is `subset`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Permissions requested, categorized by type of permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationProgrammaticAccessGrantRequestPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Date and time when the request for access was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

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