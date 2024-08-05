﻿//HintName: JsonConverters.OrgRulesetConditions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesetConditionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgRulesetConditions>
    {
        /// <inheritdoc />
        public override global::G.OrgRulesetConditions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            object? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            object? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            object? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.OrgRulesetConditions(
                value1,

                value2,

                value3
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(object).Name}, {typeof(object).Name}, {typeof(object).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref reader, options);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<object>(ref reader, options);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgRulesetConditions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(object).Name}, {typeof(object).Name}, {typeof(object).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(object), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(object), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(object), options);
            }
        }
    }
}