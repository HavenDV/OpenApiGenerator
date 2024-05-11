﻿//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model available locally.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Model modification date.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Size of the model on disk.
        /// <br/>Example: 7323310500
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}