﻿//HintName: G.Api.CancelPredictions.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCancelPredictionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string predictionId);
        partial void PrepareCancelPredictionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string predictionId);
        partial void ProcessCancelPredictionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CancelPredictionsAsync(
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCancelPredictionsArguments(
                httpClient: _httpClient,
                predictionId: ref predictionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/predictions/{predictionId}/cancel", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCancelPredictionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                predictionId: predictionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCancelPredictionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}