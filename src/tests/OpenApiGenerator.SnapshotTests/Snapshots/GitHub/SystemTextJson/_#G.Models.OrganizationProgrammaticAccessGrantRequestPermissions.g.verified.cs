﻿//HintName: G.Models.OrganizationProgrammaticAccessGrantRequestPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permissions requested, categorized by type of permission.
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrantRequestPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public object? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public object? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public object? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}