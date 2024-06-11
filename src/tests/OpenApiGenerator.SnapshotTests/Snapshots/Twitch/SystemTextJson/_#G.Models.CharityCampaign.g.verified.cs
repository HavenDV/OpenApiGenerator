﻿//HintName: G.Models.CharityCampaign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharityCampaign
    {
        /// <summary>
        /// An ID that identifies the charity campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An ID that identifies the broadcaster that’s running the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The charity’s name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityName { get; set; }

        /// <summary>
        /// A description of the charity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityDescription { get; set; }

        /// <summary>
        /// A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityLogo { get; set; }

        /// <summary>
        /// A URL to the charity’s website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_website")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityWebsite { get; set; }

        /// <summary>
        /// The current amount of donations that the campaign has received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CharityCampaignCurrentAmount CurrentAmount { get; set; }

        /// <summary>
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CharityCampaignTargetAmount TargetAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}