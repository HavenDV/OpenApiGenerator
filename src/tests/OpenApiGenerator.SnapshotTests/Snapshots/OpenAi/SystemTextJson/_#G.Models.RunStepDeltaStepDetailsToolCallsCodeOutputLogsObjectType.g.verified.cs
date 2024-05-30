﻿//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `logs`.
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType ToEnum(string value)
        {
            return value switch
            {
                "logs" => RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.Logs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}