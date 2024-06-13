﻿//HintName: G.Models.Carrier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Carrier
    {
        /// <summary>
        /// Example: Sprint Corporation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: 310
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mcc { get; set; }

        /// <summary>
        /// Example: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mnc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mnc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}