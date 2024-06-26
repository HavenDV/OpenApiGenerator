﻿//HintName: G.Models.VectorStoreFileObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_error")]
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_not_found")]
        FileNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsing_error")]
        ParsingError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unhandled_mime_type")]
        UnhandledMimeType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileObjectLastErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileObjectLastErrorCode value)
        {
            return value switch
            {
                VectorStoreFileObjectLastErrorCode.InternalError => "internal_error",
                VectorStoreFileObjectLastErrorCode.FileNotFound => "file_not_found",
                VectorStoreFileObjectLastErrorCode.ParsingError => "parsing_error",
                VectorStoreFileObjectLastErrorCode.UnhandledMimeType => "unhandled_mime_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileObjectLastErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "internal_error" => VectorStoreFileObjectLastErrorCode.InternalError,
                "file_not_found" => VectorStoreFileObjectLastErrorCode.FileNotFound,
                "parsing_error" => VectorStoreFileObjectLastErrorCode.ParsingError,
                "unhandled_mime_type" => VectorStoreFileObjectLastErrorCode.UnhandledMimeType,
                _ => null,
            };
        }
    }
}