﻿//HintName: G.Models.UserExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtension
    {
        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The extension's version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The extension's name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension is configured and can be activated. Is **true** if the extension is configured and can be activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_activate", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanActivate { get; set; } = default!;

        /// <summary>
        /// The extension types that you can activate for this extension. Possible values are:  <br/>
        ///   <br/>
        /// * component<br/>
        /// * mobile<br/>
        /// * overlay<br/>
        /// * panel
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserExtensionTypeItem> Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}