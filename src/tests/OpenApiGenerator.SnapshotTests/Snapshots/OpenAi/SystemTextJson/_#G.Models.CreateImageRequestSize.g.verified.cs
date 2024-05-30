﻿//HintName: G.Models.CreateImageRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.
    /// <br/>Default Value: 1024x1024
    /// <br/>Example: 1024x1024
    /// </summary>
    public enum CreateImageRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        _256x256,
        /// <summary>
        /// 
        /// </summary>
        _512x512,
        /// <summary>
        /// 
        /// </summary>
        _1024x1024,
        /// <summary>
        /// 
        /// </summary>
        _1792x1024,
        /// <summary>
        /// 
        /// </summary>
        _1024x1792,
    }

    public static class CreateImageRequestSizeExtensions
    {
        public static string ToValueString(this CreateImageRequestSize value)
        {
            return value switch
            {
                CreateImageRequestSize._256x256 => "256x256",
                CreateImageRequestSize._512x512 => "512x512",
                CreateImageRequestSize._1024x1024 => "1024x1024",
                CreateImageRequestSize._1792x1024 => "1792x1024",
                CreateImageRequestSize._1024x1792 => "1024x1792",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestSize ToEnum(string value)
        {
            return value switch
            {
                "256x256" => CreateImageRequestSize._256x256,
                "512x512" => CreateImageRequestSize._512x512,
                "1024x1024" => CreateImageRequestSize._1024x1024,
                "1792x1024" => CreateImageRequestSize._1792x1024,
                "1024x1792" => CreateImageRequestSize._1024x1792,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestSize ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageRequestSize._256x256,
                1 => CreateImageRequestSize._512x512,
                2 => CreateImageRequestSize._1024x1024,
                3 => CreateImageRequestSize._1792x1024,
                4 => CreateImageRequestSize._1024x1792,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}