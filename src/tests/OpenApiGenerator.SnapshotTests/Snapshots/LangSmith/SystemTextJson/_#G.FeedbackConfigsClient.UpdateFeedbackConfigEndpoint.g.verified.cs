﻿//HintName: G.FeedbackConfigsClient.UpdateFeedbackConfigEndpoint.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackConfigsClient
    {
        partial void PrepareUpdateFeedbackConfigEndpointArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateFeedbackConfigSchema request);
        partial void PrepareUpdateFeedbackConfigEndpointRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateFeedbackConfigSchema request);
        partial void ProcessUpdateFeedbackConfigEndpointResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateFeedbackConfigEndpointResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Feedback Config Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FeedbackConfigSchema> UpdateFeedbackConfigEndpointAsync(
            global::G.UpdateFeedbackConfigSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateFeedbackConfigEndpointArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/feedback-configs", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateFeedbackConfigEndpointRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateFeedbackConfigEndpointResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateFeedbackConfigEndpointResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FeedbackConfigSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Feedback Config Endpoint
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="isLowerScoreBetter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FeedbackConfigSchema> UpdateFeedbackConfigEndpointAsync(
            string feedbackKey,
            global::System.AnyOf<global::G.FeedbackConfig?, object?>? feedbackConfig = default,
            global::System.AnyOf<bool, object?>? isLowerScoreBetter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateFeedbackConfigSchema
            {
                FeedbackKey = feedbackKey,
                FeedbackConfig = feedbackConfig,
                IsLowerScoreBetter = isLowerScoreBetter,
            };

            return await UpdateFeedbackConfigEndpointAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}