﻿//HintName: G.Models.EndPredictionBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the prediction to. Possible case-sensitive values are:  
    ///   
    /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.
    /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.
    /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.
    ///   
    /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  
    ///   
    /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EndPredictionBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RESOLVED")]
        RESOLVED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOCKED")]
        LOCKED,
    }

    public static class EndPredictionBodyStatusExtensions
    {
        public static string ToValueString(this EndPredictionBodyStatus value)
        {
            return value switch
            {
                EndPredictionBodyStatus.RESOLVED => "RESOLVED",
                EndPredictionBodyStatus.CANCELED => "CANCELED",
                EndPredictionBodyStatus.LOCKED => "LOCKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EndPredictionBodyStatus ToEnum(string value)
        {
            return value switch
            {
                "RESOLVED" => EndPredictionBodyStatus.RESOLVED,
                "CANCELED" => EndPredictionBodyStatus.CANCELED,
                "LOCKED" => EndPredictionBodyStatus.LOCKED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EndPredictionBodyStatus ToEnum(int value)
        {
            return value switch
            {
                0 => EndPredictionBodyStatus.RESOLVED,
                1 => EndPredictionBodyStatus.CANCELED,
                2 => EndPredictionBodyStatus.LOCKED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}