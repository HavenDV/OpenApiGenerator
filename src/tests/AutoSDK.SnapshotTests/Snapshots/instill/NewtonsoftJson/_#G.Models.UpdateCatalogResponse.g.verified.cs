﻿//HintName: G.Models.UpdateCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateCatalogResponse represents a response for updating a catalog.
    /// </summary>
    public sealed partial class UpdateCatalogResponse
    {
        /// <summary>
        /// The updated catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalog")]
        public global::G.Catalog? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}