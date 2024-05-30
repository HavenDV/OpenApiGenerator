﻿//HintName: G.Models.GetChannelGuestStarSettingsResponseGroupLayout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   
    ///   
    /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.
    /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetChannelGuestStarSettingsResponseGroupLayout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TILED_LAYOUT")]
        TILEDLAYOUT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SCREENSHARE_LAYOUT")]
        SCREENSHARELAYOUT,
    }

    public static class GetChannelGuestStarSettingsResponseGroupLayoutExtensions
    {
        public static string ToValueString(this GetChannelGuestStarSettingsResponseGroupLayout value)
        {
            return value switch
            {
                GetChannelGuestStarSettingsResponseGroupLayout.TILEDLAYOUT => "TILED_LAYOUT",
                GetChannelGuestStarSettingsResponseGroupLayout.SCREENSHARELAYOUT => "SCREENSHARE_LAYOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetChannelGuestStarSettingsResponseGroupLayout ToEnum(string value)
        {
            return value switch
            {
                "TILED_LAYOUT" => GetChannelGuestStarSettingsResponseGroupLayout.TILEDLAYOUT,
                "SCREENSHARE_LAYOUT" => GetChannelGuestStarSettingsResponseGroupLayout.SCREENSHARELAYOUT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetChannelGuestStarSettingsResponseGroupLayout ToEnum(int value)
        {
            return value switch
            {
                0 => GetChannelGuestStarSettingsResponseGroupLayout.TILEDLAYOUT,
                1 => GetChannelGuestStarSettingsResponseGroupLayout.SCREENSHARELAYOUT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}