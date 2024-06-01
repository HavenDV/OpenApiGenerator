﻿//HintName: G.Models.GlobalEmote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalEmote
    {
        /// <summary>
        /// An ID that identifies this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  
        ///   
        /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required GlobalEmoteImages Images { get; set; }

        /// <summary>
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only `static`. But if the emote is available as a static PNG and an animated GIF, the array contains `static` and `animated`. The possible formats are:  
        ///   
        /// * animated — An animated GIF is available for this emote.
        /// * static — A static PNG file is available for this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<GlobalEmoteFormat> Format { get; set; }

        /// <summary>
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\. Possible sizes are:  
        ///   
        /// * 1.0 — A small version (28px x 28px) is available.
        /// * 2.0 — A medium version (56px x 56px) is available.
        /// * 3.0 — A large version (112px x 112px) is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<GlobalEmoteScale> Scale { get; set; }

        /// <summary>
        /// The background themes that the emote is available in. Possible themes are:  
        ///   
        /// * dark
        /// * light
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<GlobalEmoteThemeMode> ThemeMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}