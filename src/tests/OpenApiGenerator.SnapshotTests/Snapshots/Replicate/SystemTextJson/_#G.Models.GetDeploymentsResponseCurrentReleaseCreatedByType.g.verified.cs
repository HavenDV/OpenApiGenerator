﻿//HintName: G.Models.GetDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum GetDeploymentsResponseCurrentReleaseCreatedByType
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
    public static class GetDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                GetDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                GetDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => GetDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => GetDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}