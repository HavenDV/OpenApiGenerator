﻿//HintName: G.Models.AuditLogOrganizationUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogOrganizationUpdated
    {
        /// <summary>
        /// The organization ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to update the organization settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogOrganizationUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}