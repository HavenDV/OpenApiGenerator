﻿//HintName: G.Models.CreateSpeechRequestVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice to use when generating the audio. Supported voices are `alloy`, `echo`, `fable`, `onyx`, `nova`, and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech/voice-options).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alloy")]
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="echo")]
        Echo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fable")]
        Fable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="onyx")]
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova")]
        Nova,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shimmer")]
        Shimmer,
    }

    public static class CreateSpeechRequestVoiceExtensions
    {
        public static string ToValueString(this CreateSpeechRequestVoice value)
        {
            return value switch
            {
                CreateSpeechRequestVoice.Alloy => "alloy",
                CreateSpeechRequestVoice.Echo => "echo",
                CreateSpeechRequestVoice.Fable => "fable",
                CreateSpeechRequestVoice.Onyx => "onyx",
                CreateSpeechRequestVoice.Nova => "nova",
                CreateSpeechRequestVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestVoice ToEnum(string value)
        {
            return value switch
            {
                "alloy" => CreateSpeechRequestVoice.Alloy,
                "echo" => CreateSpeechRequestVoice.Echo,
                "fable" => CreateSpeechRequestVoice.Fable,
                "onyx" => CreateSpeechRequestVoice.Onyx,
                "nova" => CreateSpeechRequestVoice.Nova,
                "shimmer" => CreateSpeechRequestVoice.Shimmer,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestVoice ToEnum(int value)
        {
            return value switch
            {
                0 => CreateSpeechRequestVoice.Alloy,
                1 => CreateSpeechRequestVoice.Echo,
                2 => CreateSpeechRequestVoice.Fable,
                3 => CreateSpeechRequestVoice.Onyx,
                4 => CreateSpeechRequestVoice.Nova,
                5 => CreateSpeechRequestVoice.Shimmer,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}