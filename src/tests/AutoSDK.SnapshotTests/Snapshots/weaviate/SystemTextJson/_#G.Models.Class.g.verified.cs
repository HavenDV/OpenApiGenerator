﻿//HintName: G.Models.Class.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Class
    {
        /// <summary>
        /// Name of the collection (a.k.a. class). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class1 { get; set; }

        /// <summary>
        /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorConfig")]
        public global::G.ClassVectorConfig? VectorConfig { get; set; }

        /// <summary>
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorIndexTypeJsonConverter))]
        public global::G.VectorIndexType? VectorIndexType { get; set; } = global::G.VectorIndexType.Hnsw;

        /// <summary>
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexConfig")]
        public global::G.VectorIndexConfig? VectorIndexConfig { get; set; }

        /// <summary>
        /// Specify how the index should be sharded and distributed in the cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardingConfig")]
        public global::G.ShardingConfig? ShardingConfig { get; set; }

        /// <summary>
        /// Configure how replication is executed in a cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicationConfig")]
        public global::G.ReplicationConfig? ReplicationConfig { get; set; }

        /// <summary>
        /// Configure the inverted index built into Weaviate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invertedIndexConfig")]
        public global::G.InvertedIndexConfig? InvertedIndexConfig { get; set; }

        /// <summary>
        /// Configuration related to multi-tenancy within a class
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiTenancyConfig")]
        public global::G.MultiTenancyConfig? MultiTenancyConfig { get; set; }

        /// <summary>
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorizerJsonConverter))]
        public global::G.Vectorizer? Vectorizer { get; set; }

        /// <summary>
        /// Configuration specific to modules in a collection context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleConfig")]
        public global::G.ClassModuleConfig? ModuleConfig { get; set; }

        /// <summary>
        /// Description of the collection for documentation purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Define properties of the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::G.Property>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}