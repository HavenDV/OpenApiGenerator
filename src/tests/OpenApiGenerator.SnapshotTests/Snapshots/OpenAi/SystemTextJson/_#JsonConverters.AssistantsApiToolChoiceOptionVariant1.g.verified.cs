﻿//HintName: JsonConverters.AssistantsApiToolChoiceOptionVariant1.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssistantsApiToolChoiceOptionVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantsApiToolChoiceOptionVariant1>
    {
        /// <inheritdoc />
        public override global::G.AssistantsApiToolChoiceOptionVariant1 Read(
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
                        return global::G.AssistantsApiToolChoiceOptionVariant1Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AssistantsApiToolChoiceOptionVariant1)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantsApiToolChoiceOptionVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AssistantsApiToolChoiceOptionVariant1Extensions.ToValueString(value));
        }
    }
}
