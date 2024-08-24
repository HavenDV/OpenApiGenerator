﻿//HintName: G.Models.DeleteTextureGenerationByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTextureGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "model_asset_texture_generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_model_asset_texture_generations_by_pk")]
        public global::G.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk? DeleteModelAssetTextureGenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}