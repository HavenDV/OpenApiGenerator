﻿//HintName: JsonConverters.WebhookIssueCommentEditedIssueMilestoneState.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueMilestoneStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentEditedIssueMilestoneState>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueMilestoneState Read(
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
                        return global::G.WebhookIssueCommentEditedIssueMilestoneStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentEditedIssueMilestoneState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueMilestoneState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssueCommentEditedIssueMilestoneStateExtensions.ToValueString(value));
        }
    }
}