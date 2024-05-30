﻿//HintName: JsonConverters.PullModelResponseStatus.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class PullModelResponseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PullModelResponseStatus>
    {
        public override global::G.PullModelResponseStatus Read(
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
                        return global::G.PullModelResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.PullModelResponseStatusExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PullModelResponseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.PullModelResponseStatusExtensions.ToValueString(value));
        }
    }
}
