﻿//HintName: G.Models.GenerateChatCompletionRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return a response in. Currently the only accepted value is json.
    /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.
    /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
    /// </summary>
    public enum GenerateChatCompletionRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    public static class GenerateChatCompletionRequestFormatExtensions
    {
        public static string ToValueString(this GenerateChatCompletionRequestFormat value)
        {
            return value switch
            {
                GenerateChatCompletionRequestFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GenerateChatCompletionRequestFormat ToEnum(string value)
        {
            return value switch
            {
                "json" => GenerateChatCompletionRequestFormat.Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GenerateChatCompletionRequestFormat ToEnum(int value)
        {
            return value switch
            {
                0 => GenerateChatCompletionRequestFormat.Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}