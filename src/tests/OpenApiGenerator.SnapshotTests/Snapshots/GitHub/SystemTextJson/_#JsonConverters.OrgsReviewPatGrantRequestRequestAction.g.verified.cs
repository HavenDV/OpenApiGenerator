﻿//HintName: JsonConverters.OrgsReviewPatGrantRequestRequestAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgsReviewPatGrantRequestRequestActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgsReviewPatGrantRequestRequestAction>
    {
        /// <inheritdoc />
        public override global::G.OrgsReviewPatGrantRequestRequestAction Read(
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
                        return global::G.OrgsReviewPatGrantRequestRequestActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OrgsReviewPatGrantRequestRequestAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgsReviewPatGrantRequestRequestAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.OrgsReviewPatGrantRequestRequestActionExtensions.ToValueString(value));
        }
    }
}