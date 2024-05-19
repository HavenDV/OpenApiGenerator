﻿//HintName: G.Models.ChatCompletionFunctionParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFunctionParameters
    {
        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "";

        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public ChatCompletionFunctionParametersProperties? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}