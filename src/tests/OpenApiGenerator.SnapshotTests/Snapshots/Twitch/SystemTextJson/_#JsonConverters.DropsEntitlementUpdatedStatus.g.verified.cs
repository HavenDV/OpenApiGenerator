﻿//HintName: JsonConverters.DropsEntitlementUpdatedStatus.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DropsEntitlementUpdatedStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DropsEntitlementUpdatedStatus>
    {
        /// <inheritdoc />
        public override global::G.DropsEntitlementUpdatedStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.DropsEntitlementUpdatedStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DropsEntitlementUpdatedStatus)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DropsEntitlementUpdatedStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.DropsEntitlementUpdatedStatusExtensions.ToValueString(value));
        }
    }
}
