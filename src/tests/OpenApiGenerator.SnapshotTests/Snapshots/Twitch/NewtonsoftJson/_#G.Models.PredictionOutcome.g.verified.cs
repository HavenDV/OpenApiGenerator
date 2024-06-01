﻿//HintName: G.Models.PredictionOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionOutcome
    {
        /// <summary>
        /// An ID that identifies this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The outcome’s text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The number of unique viewers that chose this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public int Users { get; set; } = default!;

        /// <summary>
        /// The number of Channel Points spent by viewers on this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPoints { get; set; } = default!;

        /// <summary>
        /// A list of viewers who were the top predictors; otherwise, **null** if none.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_predictors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<PredictionOutcomeTopPredictors>? TopPredictors { get; set; } = default!;

        /// <summary>
        /// The color that visually identifies this outcome in the UX. Possible values are:  
        ///   
        /// * BLUE
        /// * PINK
        ///   
        /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public PredictionOutcomeColor Color { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}