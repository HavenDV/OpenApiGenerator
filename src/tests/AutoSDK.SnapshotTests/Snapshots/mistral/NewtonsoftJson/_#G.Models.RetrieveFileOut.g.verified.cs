﻿//HintName: G.Models.RetrieveFileOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveFileOut
    {
        /// <summary>
        /// The size of the file, in bytes.<br/>
        /// Example: 13000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.<br/>
        /// Example: 1716963433
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the uploaded file.<br/>
        /// Example: files_upload.jsonl
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// The object type, which is always "file".<br/>
        /// Example: file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.<br/>
        /// Example: fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public global::G.RetrieveFileOutPurpose Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SampleType SampleType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}