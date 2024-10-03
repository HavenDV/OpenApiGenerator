﻿//HintName: G.Models.UserMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: user
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageRole value)
        {
            return value switch
            {
                UserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserMessageRole.User,
                _ => null,
            };
        }
    }
}