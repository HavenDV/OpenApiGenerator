﻿//HintName: G.Models.RepositoryRuleNonFastForward.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent users with push access from force pushing to refs.
    /// </summary>
    public sealed partial class RepositoryRuleNonFastForward
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleNonFastForwardTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleNonFastForwardType Type { get; set; } = global::G.RepositoryRuleNonFastForwardType.NonFastForward;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}