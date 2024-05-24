﻿//HintName: G.Models.NullableScopedInstallation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NullableScopedInstallation
    {
        /// <summary>
        /// The permissions granted to the user access token.
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required AppPermissions Permissions { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositorySelection { get; set; }

        /// <summary>
        /// <br/>Example: config.yaml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SingleFileName { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_multiple_single_files")]
        public bool HasMultipleSingleFiles { get; set; }

        /// <summary>
        /// <br/>Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_paths")]
        public global::System.Collections.Generic.IList<string?>? SingleFilePaths { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/repos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleUser Account { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}