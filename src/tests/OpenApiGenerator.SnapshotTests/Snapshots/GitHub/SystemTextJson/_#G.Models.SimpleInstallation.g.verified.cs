﻿//HintName: G.Models.SimpleInstallation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured
    /// for and sent to a GitHub App. For more information,
    /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
    /// </summary>
    public sealed partial class SimpleInstallation
    {
        /// <summary>
        /// The ID of the installation.
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The global node ID of the installation.
        /// <br/>Example: MDQ6VXNlcjU4MzIzMQ==
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}