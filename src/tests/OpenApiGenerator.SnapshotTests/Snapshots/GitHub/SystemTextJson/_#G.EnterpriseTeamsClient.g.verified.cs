﻿//HintName: G.EnterpriseTeamsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Endpoints to manage GitHub Enterprise Teams.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class EnterpriseTeamsClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Creates a new instance of the EnterpriseTeamsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public EnterpriseTeamsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.github.com");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}