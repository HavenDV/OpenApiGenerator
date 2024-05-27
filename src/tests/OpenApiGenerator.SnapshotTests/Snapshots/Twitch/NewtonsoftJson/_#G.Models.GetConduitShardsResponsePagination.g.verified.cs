﻿//HintName: G.Models.GetConduitShardsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    public sealed partial class GetConduitShardsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}