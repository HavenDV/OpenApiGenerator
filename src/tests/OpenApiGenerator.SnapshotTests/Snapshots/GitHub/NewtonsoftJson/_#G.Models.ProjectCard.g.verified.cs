﻿//HintName: G.Models.ProjectCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project cards represent a scope of work.
    /// </summary>
    public sealed partial class ProjectCard
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/projects/columns/cards/1478
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The project card's ID
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Add payload for delete Project column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Note { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether or not the card is archived
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/projects/columns/367
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/projects/120
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}