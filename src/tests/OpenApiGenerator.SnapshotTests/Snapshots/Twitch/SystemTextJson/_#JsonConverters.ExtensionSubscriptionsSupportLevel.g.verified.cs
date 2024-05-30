﻿//HintName: JsonConverters.ExtensionSubscriptionsSupportLevel.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtensionSubscriptionsSupportLevelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExtensionSubscriptionsSupportLevel>
    {
        /// <inheritdoc />
        public override global::G.ExtensionSubscriptionsSupportLevel Read(
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
                        return global::G.ExtensionSubscriptionsSupportLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ExtensionSubscriptionsSupportLevel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExtensionSubscriptionsSupportLevel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ExtensionSubscriptionsSupportLevelExtensions.ToValueString(value));
        }
    }
}
