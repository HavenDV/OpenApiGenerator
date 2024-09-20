﻿//HintName: G.Models.GetSourceFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSourceFileResponse
    {
        /// <summary>
        /// The SourceFile message represents a source file in the artifact system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceFile")]
        public global::G.SourceFile? SourceFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}