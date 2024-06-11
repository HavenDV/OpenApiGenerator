﻿//HintName: G.Models.CreateModelStatusVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelStatusVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creating system layer")]
        CreatingSystemLayer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsing modelfile")]
        ParsingModelfile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelStatusVariant2 value)
        {
            return value switch
            {
                CreateModelStatusVariant2.CreatingSystemLayer => "creating system layer",
                CreateModelStatusVariant2.ParsingModelfile => "parsing modelfile",
                CreateModelStatusVariant2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "creating system layer" => CreateModelStatusVariant2.CreatingSystemLayer,
                "parsing modelfile" => CreateModelStatusVariant2.ParsingModelfile,
                "success" => CreateModelStatusVariant2.Success,
                _ => null,
            };
        }
    }
}