﻿//HintName: G.Models.LegacyJobMetadataOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyJobMetadataOut
    {
        /// <summary>
        /// The cost of the fine-tuning job.<br/>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// The currency used for the fine-tuning job cost.<br/>
        /// Example: EUR
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// The total number of tokens in the training dataset.<br/>
        /// Example: 305375
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_tokens")]
        public int? DataTokens { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public bool? Deprecated { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public string Details { get; set; } = default!;

        /// <summary>
        /// The number of complete passes through the entire training dataset.<br/>
        /// Example: 4.2922
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_start_time")]
        public int? EstimatedStartTime { get; set; }

        /// <summary>
        /// The approximated time (in seconds) for the fine-tuning process to complete.<br/>
        /// Example: 220
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_duration_seconds")]
        public int? ExpectedDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: job.metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.LegacyJobMetadataOutObject? Object { get; set; } = global::G.LegacyJobMetadataOutObject.JobMetadata;

        /// <summary>
        /// The total number of tokens used during the fine-tuning process.<br/>
        /// Example: 1310720
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_tokens")]
        public int? TrainTokens { get; set; }

        /// <summary>
        /// The number of tokens consumed by one training step.<br/>
        /// Example: 131072
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_tokens_per_step")]
        public int? TrainTokensPerStep { get; set; }

        /// <summary>
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.<br/>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}