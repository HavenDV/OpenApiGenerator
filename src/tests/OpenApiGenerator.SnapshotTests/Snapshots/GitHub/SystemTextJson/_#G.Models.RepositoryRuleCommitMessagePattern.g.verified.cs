﻿//HintName: G.Models.RepositoryRuleCommitMessagePattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the commit_message_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleCommitMessagePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleCommitMessagePatternTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleCommitMessagePatternType Type { get; set; } = global::G.RepositoryRuleCommitMessagePatternType.CommitMessagePattern;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleCommitMessagePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}