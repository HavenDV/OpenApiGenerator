﻿//HintName: G.Models.RuleSuiteRuleEvaluationsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the evaluation of the individual rule.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteRuleEvaluationsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteRuleEvaluationsResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteRuleEvaluationsResult value)
        {
            return value switch
            {
                RuleSuiteRuleEvaluationsResult.Pass => "pass",
                RuleSuiteRuleEvaluationsResult.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteRuleEvaluationsResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuiteRuleEvaluationsResult.Pass,
                "fail" => RuleSuiteRuleEvaluationsResult.Fail,
                _ => null,
            };
        }
    }
}