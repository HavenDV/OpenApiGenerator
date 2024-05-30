﻿//HintName: G.Models.CreateModerationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        TextModerationLatest,
        /// <summary>
        /// 
        /// </summary>
        TextModerationStable,
    }

    public static class CreateModerationRequestModelExtensions
    {
        public static string ToValueString(this CreateModerationRequestModel value)
        {
            return value switch
            {
                CreateModerationRequestModel.TextModerationLatest => "text-moderation-latest",
                CreateModerationRequestModel.TextModerationStable => "text-moderation-stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateModerationRequestModel ToEnum(string value)
        {
            return value switch
            {
                "text-moderation-latest" => CreateModerationRequestModel.TextModerationLatest,
                "text-moderation-stable" => CreateModerationRequestModel.TextModerationStable,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateModerationRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateModerationRequestModel.TextModerationLatest,
                1 => CreateModerationRequestModel.TextModerationStable,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}