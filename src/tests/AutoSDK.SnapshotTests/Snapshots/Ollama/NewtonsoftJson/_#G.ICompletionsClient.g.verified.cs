﻿//HintName: G.ICompletionsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Given a prompt, the model will generate a completion.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICompletionsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}