﻿//HintName: G.Models.AssistantObjectResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum AssistantObjectResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class AssistantObjectResponseFormatExtensions
    {
        public static string ToValueString(this AssistantObjectResponseFormat value)
        {
            return value switch
            {
                AssistantObjectResponseFormat.None => "none",
                AssistantObjectResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantObjectResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => AssistantObjectResponseFormat.None,
                "auto" => AssistantObjectResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantObjectResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantObjectResponseFormat.None,
                1 => AssistantObjectResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}