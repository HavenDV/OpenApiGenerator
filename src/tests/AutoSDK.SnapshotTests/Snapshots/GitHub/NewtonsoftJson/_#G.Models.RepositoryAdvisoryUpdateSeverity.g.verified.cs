﻿//HintName: G.Models.RepositoryAdvisoryUpdateSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryUpdateSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryUpdateSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryUpdateSeverity value)
        {
            return value switch
            {
                RepositoryAdvisoryUpdateSeverity.Critical => "critical",
                RepositoryAdvisoryUpdateSeverity.High => "high",
                RepositoryAdvisoryUpdateSeverity.Medium => "medium",
                RepositoryAdvisoryUpdateSeverity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryUpdateSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => RepositoryAdvisoryUpdateSeverity.Critical,
                "high" => RepositoryAdvisoryUpdateSeverity.High,
                "medium" => RepositoryAdvisoryUpdateSeverity.Medium,
                "low" => RepositoryAdvisoryUpdateSeverity.Low,
                _ => null,
            };
        }
    }
}