﻿//HintName: G.Models.CreateCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateCatalogResponse represents a response for creating a catalog.
    /// </summary>
    public sealed partial class CreateCatalogResponse
    {
        /// <summary>
        /// The created catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Catalog Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}