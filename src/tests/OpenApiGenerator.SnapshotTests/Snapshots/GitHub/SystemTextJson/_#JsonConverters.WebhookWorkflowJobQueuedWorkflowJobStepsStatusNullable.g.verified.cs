﻿//HintName: JsonConverters.WebhookWorkflowJobQueuedWorkflowJobStepsStatusNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobQueuedWorkflowJobStepsStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatus?>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatus? Read(
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
                        return global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatus)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookWorkflowJobQueuedWorkflowJobStepsStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}