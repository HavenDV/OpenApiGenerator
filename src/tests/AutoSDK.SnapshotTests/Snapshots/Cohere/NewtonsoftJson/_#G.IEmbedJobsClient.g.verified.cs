﻿//HintName: G.IEmbedJobsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Embed Jobs API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEmbedJobsClient : global::System.IDisposable
    {
        /// <summary>
        /// production
        /// </summary>
        public const string BaseUrl = "https://api.cohere.com";

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}