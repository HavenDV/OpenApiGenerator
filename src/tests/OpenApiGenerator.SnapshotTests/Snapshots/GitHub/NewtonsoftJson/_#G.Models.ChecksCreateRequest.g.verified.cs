﻿//HintName: G.Models.ChecksCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequest
    {
        /// <summary>
        /// The name of the check. For example, "code-coverage".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details_url")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// A reference for the run on the integrator's system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
        /// Default Value: queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ChecksCreateRequestStatus? Status { get; set; } = global::G.ChecksCreateRequestStatus.Queued;

        /// <summary>
        /// The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
        /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        public global::G.ChecksCreateRequestConclusion? Conclusion { get; set; }

        /// <summary>
        /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime CompletedAt { get; set; }

        /// <summary>
        /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.ChecksCreateRequestOutput? Output { get; set; }

        /// <summary>
        /// Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. To learn more about check runs and requested actions, see "[Check runs and requested actions](https://docs.github.com/rest/guides/using-the-rest-api-to-interact-with-checks#check-runs-and-requested-actions)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions")]
        public global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}