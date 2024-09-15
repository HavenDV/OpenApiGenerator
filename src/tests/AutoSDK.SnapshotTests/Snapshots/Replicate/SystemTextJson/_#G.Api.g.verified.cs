﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A web service for running Replicate models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.replicate.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.ModelsCreateRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.AccountGetResponseTypeJsonConverter(),
                    new global::G.JsonConverters.AccountGetResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                }
            };


        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}