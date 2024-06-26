﻿//HintName: G.PrivacyDetectionClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Privacy Detection API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class PrivacyDetectionClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://ipinfo.io/";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::Newtonsoft.Json.JsonSerializerSettings _jsonSerializerOptions;


        /// <summary>
        /// Creates a new instance of the PrivacyDetectionClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public PrivacyDetectionClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::Newtonsoft.Json.JsonSerializerSettings();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}