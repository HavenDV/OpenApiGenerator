﻿//HintName: G.Models.CreateImageRequestStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.
    /// <br/>Default Value: vivid
    /// <br/>Example: vivid
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vivid")]
        Vivid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="natural")]
        Natural,
    }
}