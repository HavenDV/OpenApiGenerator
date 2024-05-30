﻿//HintName: G.Models.CreateThreadAndRunRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateThreadAndRunRequestResponseFormat
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

    public static class CreateThreadAndRunRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateThreadAndRunRequestResponseFormat value)
        {
            return value switch
            {
                CreateThreadAndRunRequestResponseFormat.None => "none",
                CreateThreadAndRunRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateThreadAndRunRequestResponseFormat.None,
                "auto" => CreateThreadAndRunRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateThreadAndRunRequestResponseFormat.None,
                1 => CreateThreadAndRunRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}