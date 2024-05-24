﻿//HintName: G.Models.AppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for deployments and deployment statuses.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsDeployments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }
}