﻿//HintName: G.Models.ReposRemoveTeamAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: 
    /// </summary>
    public sealed partial class ReposRemoveTeamAccessRestrictionsRequest
    {
        /// <summary>
        /// The slug values for teams
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Teams { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}