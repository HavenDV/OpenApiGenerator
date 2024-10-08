﻿//HintName: G.Models.ChatSearchResultConnector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The connector used for fetching documents.
    /// </summary>
    public sealed partial class ChatSearchResultConnector
    {
        /// <summary>
        /// The identifier of the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}