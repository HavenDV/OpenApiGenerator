﻿//HintName: G.Models.GetModeratedChannelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModeratedChannelsResponse
    {
        /// <summary>
        /// The list of channels that the user has moderator privileges in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<GetModeratedChannelsResponseData> Data { get; set; } = default!;

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public GetModeratedChannelsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}