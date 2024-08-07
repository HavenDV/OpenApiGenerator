﻿//HintName: G.Models.CreateModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelResponseStatus
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
    public static class CreateModelResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseStatus value)
        {
            return value switch
            {
                CreateModelResponseStatus.CreatingSystemLayer => "creating system layer",
                CreateModelResponseStatus.ParsingModelfile => "parsing modelfile",
                CreateModelResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "creating system layer" => CreateModelResponseStatus.CreatingSystemLayer,
                "parsing modelfile" => CreateModelResponseStatus.ParsingModelfile,
                "success" => CreateModelResponseStatus.Success,
                _ => null,
            };
        }
    }
}