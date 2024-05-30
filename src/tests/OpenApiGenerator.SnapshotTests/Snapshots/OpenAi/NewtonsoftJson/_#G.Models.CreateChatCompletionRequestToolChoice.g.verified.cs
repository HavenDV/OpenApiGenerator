﻿//HintName: G.Models.CreateChatCompletionRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestToolChoice
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required")]
        Required,
    }

    public static class CreateChatCompletionRequestToolChoiceExtensions
    {
        public static string ToValueString(this CreateChatCompletionRequestToolChoice value)
        {
            return value switch
            {
                CreateChatCompletionRequestToolChoice.None => "none",
                CreateChatCompletionRequestToolChoice.Auto => "auto",
                CreateChatCompletionRequestToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestToolChoice ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateChatCompletionRequestToolChoice.None,
                "auto" => CreateChatCompletionRequestToolChoice.Auto,
                "required" => CreateChatCompletionRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestToolChoice ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionRequestToolChoice.None,
                1 => CreateChatCompletionRequestToolChoice.Auto,
                2 => CreateChatCompletionRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}