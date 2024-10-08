﻿//HintName: G.Models.RangesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RangesResponse
    {
        /// <summary>
        /// Example: comcast.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Example: 37330
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ranges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}