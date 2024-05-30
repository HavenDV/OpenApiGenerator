﻿//HintName: G.Models.ListRunsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListRunsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    public static class ListRunsOrderExtensions
    {
        public static string ToValueString(this ListRunsOrder value)
        {
            return value switch
            {
                ListRunsOrder.Asc => "asc",
                ListRunsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListRunsOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListRunsOrder.Asc,
                "desc" => ListRunsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListRunsOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListRunsOrder.Asc,
                1 => ListRunsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}