﻿//HintName: G.Models.CreateChatCompletionRequestFunctionCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call a function and instead generates a message. `auto` means the model can pick between generating a message or calling a function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestFunctionCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestFunctionCallExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestFunctionCall value)
        {
            return value switch
            {
                CreateChatCompletionRequestFunctionCall.None => "none",
                CreateChatCompletionRequestFunctionCall.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestFunctionCall ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateChatCompletionRequestFunctionCall.None,
                "auto" => CreateChatCompletionRequestFunctionCall.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}