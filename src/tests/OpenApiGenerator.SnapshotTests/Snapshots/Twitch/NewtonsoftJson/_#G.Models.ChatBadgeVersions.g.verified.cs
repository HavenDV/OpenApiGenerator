﻿//HintName: G.Models.ChatBadgeVersions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatBadgeVersions
    {
        /// <summary>
        /// An ID that identifies this version of the badge. The ID can be any value. For example, for Bits, the ID is the Bits tier level, but for World of Warcraft, it could be Alliance or Horde.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A URL to the small version (18px x 18px) of the badge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url_1x", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageUrl1x { get; set; } = default!;

        /// <summary>
        /// A URL to the medium version (36px x 36px) of the badge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url_2x", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageUrl2x { get; set; } = default!;

        /// <summary>
        /// A URL to the large version (72px x 72px) of the badge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url_4x", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageUrl4x { get; set; } = default!;

        /// <summary>
        /// The title of the badge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The description of the badge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The action to take when clicking on the badge. Set to `null` if no action is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("click_action", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClickAction { get; set; } = default!;

        /// <summary>
        /// The URL to navigate to when clicking on the badge. Set to `null` if no URL is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("click_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClickUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}