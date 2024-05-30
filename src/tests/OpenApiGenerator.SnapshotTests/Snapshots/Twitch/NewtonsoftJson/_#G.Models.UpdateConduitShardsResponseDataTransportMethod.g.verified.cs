﻿//HintName: G.Models.UpdateConduitShardsResponseDataTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateConduitShardsResponseDataTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket")]
        Websocket,
    }

    public static class UpdateConduitShardsResponseDataTransportMethodExtensions
    {
        public static string ToValueString(this UpdateConduitShardsResponseDataTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsResponseDataTransportMethod.Webhook => "webhook",
                UpdateConduitShardsResponseDataTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsResponseDataTransportMethod ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsResponseDataTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsResponseDataTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsResponseDataTransportMethod ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateConduitShardsResponseDataTransportMethod.Webhook,
                1 => UpdateConduitShardsResponseDataTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}