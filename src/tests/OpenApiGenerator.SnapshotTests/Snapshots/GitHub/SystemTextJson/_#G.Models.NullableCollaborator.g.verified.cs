﻿//HintName: G.Models.NullableCollaborator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Collaborator
    /// </summary>
    public sealed partial class NullableCollaborator
    {
        /// <summary>
        /// <br/>Example: octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <br/>Example: MDQ6VXNlcjE=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// <br/>Example: 41d064eb2195891e12d0413f63227ea7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gravatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? GravatarId { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/followers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FollowersUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/following{/other_user}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("following_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FollowingUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/gists{/gist_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gists_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GistsUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/starred{/owner}{/repo}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StarredUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/subscriptions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionsUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/orgs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationsUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/repos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReposUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/events{/privacy}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/users/octocat/received_events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceivedEventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: User
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SiteAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public NullableCollaboratorPermissions? Permissions { get; set; }

        /// <summary>
        /// <br/>Example: admin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}