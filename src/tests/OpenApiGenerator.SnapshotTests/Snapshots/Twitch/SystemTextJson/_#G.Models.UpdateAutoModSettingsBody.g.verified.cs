﻿//HintName: G.Models.UpdateAutoModSettingsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoModSettingsBody
    {
        /// <summary>
        /// The Automod level for hostility involving aggression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggression")]
        public int Aggression { get; set; }

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullying")]
        public int Bullying { get; set; }

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disability")]
        public int Disability { get; set; }

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misogyny")]
        public int Misogyny { get; set; }

        /// <summary>
        /// The default AutoMod level for the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_level")]
        public int OverallLevel { get; set; }

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("race_ethnicity_or_religion")]
        public int RaceEthnicityOrReligion { get; set; }

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex_based_terms")]
        public int SexBasedTerms { get; set; }

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexuality_sex_or_gender")]
        public int SexualitySexOrGender { get; set; }

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swearing")]
        public int Swearing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}