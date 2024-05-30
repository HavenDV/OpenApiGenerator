﻿//HintName: G.Models.CreateImageEditRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageEditRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DallE2,
    }

    public static class CreateImageEditRequestModelExtensions
    {
        public static string ToValueString(this CreateImageEditRequestModel value)
        {
            return value switch
            {
                CreateImageEditRequestModel.DallE2 => "dall-e-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageEditRequestModel ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageEditRequestModel.DallE2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageEditRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageEditRequestModel.DallE2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}