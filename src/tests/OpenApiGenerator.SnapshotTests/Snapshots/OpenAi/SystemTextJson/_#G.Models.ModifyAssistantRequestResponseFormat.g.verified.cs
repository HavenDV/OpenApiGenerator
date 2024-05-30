﻿//HintName: G.Models.ModifyAssistantRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum ModifyAssistantRequestResponseFormat
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyAssistantRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyAssistantRequestResponseFormat value)
        {
            return value switch
            {
                ModifyAssistantRequestResponseFormat.None => "none",
                ModifyAssistantRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyAssistantRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => ModifyAssistantRequestResponseFormat.None,
                "auto" => ModifyAssistantRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}