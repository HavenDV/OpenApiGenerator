﻿//HintName: G.Models.OrgCustomProperty.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Custom property defined on an organization
    /// </summary>
    public sealed partial class OrgCustomProperty
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyName { get; set; } = default!;

        /// <summary>
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgCustomPropertyValueType ValueType { get; set; } = default!;

        /// <summary>
        /// Whether the property is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default value of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? DefaultValue { get; set; }

        /// <summary>
        /// Short description of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_values")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        /// Who can edit the values of the property<br/>
        /// Example: org_actors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values_editable_by")]
        public global::G.OrgCustomPropertyValuesEditableBy? ValuesEditableBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}