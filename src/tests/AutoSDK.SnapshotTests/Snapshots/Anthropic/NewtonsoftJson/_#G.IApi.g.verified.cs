﻿//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Spec for Anthropic API. Please see https://docs.anthropic.com/en/api for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}