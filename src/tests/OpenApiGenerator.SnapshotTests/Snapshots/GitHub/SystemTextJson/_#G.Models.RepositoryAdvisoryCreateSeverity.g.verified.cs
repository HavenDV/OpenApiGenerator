﻿//HintName: G.Models.RepositoryAdvisoryCreateSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
    /// </summary>
    public abstract class RepositoryAdvisoryCreateSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Critical = "critical";
        /// <summary>
        /// 
        /// </summary>
        public const string High = "high";
        /// <summary>
        /// 
        /// </summary>
        public const string Medium = "medium";
        /// <summary>
        /// 
        /// </summary>
        public const string Low = "low";
    }
}