﻿//HintName: G.Models.CodeScanningAnalysisDeletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Successful deletion of a code scanning analysis
    /// </summary>
    public sealed partial class CodeScanningAnalysisDeletion
    {
        /// <summary>
        /// Next deletable analysis in chain, without last analysis deletion confirmation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_analysis_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextAnalysisUrl { get; set; }

        /// <summary>
        /// Next deletable analysis in chain, with last analysis deletion confirmation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirm_delete_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ConfirmDeleteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}