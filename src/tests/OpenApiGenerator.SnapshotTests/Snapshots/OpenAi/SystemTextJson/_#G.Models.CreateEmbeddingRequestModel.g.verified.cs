﻿//HintName: G.Models.CreateEmbeddingRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEmbeddingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbeddingAda002,
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Small,
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Large,
    }

    public static class CreateEmbeddingRequestModelExtensions
    {
        public static string ToValueString(this CreateEmbeddingRequestModel value)
        {
            return value switch
            {
                CreateEmbeddingRequestModel.TextEmbeddingAda002 => "text-embedding-ada-002",
                CreateEmbeddingRequestModel.TextEmbedding3Small => "text-embedding-3-small",
                CreateEmbeddingRequestModel.TextEmbedding3Large => "text-embedding-3-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEmbeddingRequestModel ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-ada-002" => CreateEmbeddingRequestModel.TextEmbeddingAda002,
                "text-embedding-3-small" => CreateEmbeddingRequestModel.TextEmbedding3Small,
                "text-embedding-3-large" => CreateEmbeddingRequestModel.TextEmbedding3Large,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEmbeddingRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateEmbeddingRequestModel.TextEmbeddingAda002,
                1 => CreateEmbeddingRequestModel.TextEmbedding3Small,
                2 => CreateEmbeddingRequestModel.TextEmbedding3Large,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}