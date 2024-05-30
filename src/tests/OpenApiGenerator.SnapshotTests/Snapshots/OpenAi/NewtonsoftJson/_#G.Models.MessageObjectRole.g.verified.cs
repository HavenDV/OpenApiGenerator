﻿//HintName: G.Models.MessageObjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity that produced the message. One of `user` or `assistant`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageObjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectRole value)
        {
            return value switch
            {
                MessageObjectRole.User => "user",
                MessageObjectRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectRole ToEnum(string value)
        {
            return value switch
            {
                "user" => MessageObjectRole.User,
                "assistant" => MessageObjectRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}