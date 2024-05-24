﻿//HintName: G.Models.MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// <br/>Default Value: open
    /// <br/>Example: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }
}