﻿//HintName: G.Models.ActionsUpdateOrgVariableRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateOrgVariableRequest
    {
        /// <summary>
        /// The name of the variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.ActionsUpdateOrgVariableRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// An array of repository ids that can access the organization variable. You can only provide a list of repository ids when the `visibility` is set to `selected`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}