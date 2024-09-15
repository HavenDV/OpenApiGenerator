﻿//HintName: G.IDomainsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hosted Domains API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDomainsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://ipinfo.io/";

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}