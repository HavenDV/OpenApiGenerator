﻿//HintName: G.Models.Permission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a resource can be used.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Defines whether the resource can be modified.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}