﻿//HintName: G.Models.GenerateChatCompletionRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return a response in. Currently the only accepted value is json.
    /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.
    /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateChatCompletionRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateChatCompletionRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateChatCompletionRequestFormat value)
        {
            return value switch
            {
                GenerateChatCompletionRequestFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateChatCompletionRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => GenerateChatCompletionRequestFormat.Json,
                _ => null,
            };
        }
    }
}