﻿//HintName: G.Models.RepositoryRuleRulesetInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    public sealed partial class RepositoryRuleRulesetInfo
    {
        /// <summary>
        /// The type of source for the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleRulesetInfoRulesetSourceTypeJsonConverter))]
        public global::G.RepositoryRuleRulesetInfoRulesetSourceType? RulesetSourceType { get; set; }

        /// <summary>
        /// The name of the source of the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_source")]
        public string? RulesetSource { get; set; }

        /// <summary>
        /// The ID of the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_id")]
        public int? RulesetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}