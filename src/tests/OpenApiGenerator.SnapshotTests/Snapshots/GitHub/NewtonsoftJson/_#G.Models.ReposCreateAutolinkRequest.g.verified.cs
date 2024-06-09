﻿//HintName: G.Models.ReposCreateAutolinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateAutolinkRequest
    {
        /// <summary>
        /// This prefix appended by certain characters will generate a link any time it is found in an issue, pull request, or commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyPrefix { get; set; } = default!;

        /// <summary>
        /// The URL must contain `&lt;num&gt;` for the reference number. `&lt;num&gt;` matches different characters depending on the value of `is_alphanumeric`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_template", Required = global::Newtonsoft.Json.Required.Always)]
        public string UrlTemplate { get; set; } = default!;

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If true, the `&lt;num&gt;` parameter of the `url_template` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`. If false, this autolink reference only matches numeric characters.
        /// <br/>Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_alphanumeric")]
        public bool IsAlphanumeric { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}