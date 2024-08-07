﻿//HintName: G.Models.GetAccountResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type. Can be a user or an organization.
    /// </summary>
    public enum GetAccountResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAccountResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountResponseType value)
        {
            return value switch
            {
                GetAccountResponseType.Organization => "organization",
                GetAccountResponseType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountResponseType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => GetAccountResponseType.Organization,
                "user" => GetAccountResponseType.User,
                _ => null,
            };
        }
    }
}