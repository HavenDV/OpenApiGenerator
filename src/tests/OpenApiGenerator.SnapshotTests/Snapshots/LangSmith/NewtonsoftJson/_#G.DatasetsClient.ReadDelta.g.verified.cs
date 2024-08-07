﻿//HintName: G.DatasetsClient.ReadDelta.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadDeltaArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::G.QueryFeedbackDelta request);
        partial void PrepareReadDeltaRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::G.QueryFeedbackDelta request);
        partial void ProcessReadDeltaResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadDeltaResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadDeltaAsync(
            string datasetId,
            global::G.QueryFeedbackDelta request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadDeltaArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/runs/delta", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadDeltaRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadDeltaResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadDeltaResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SessionFeedbackDelta?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadDeltaAsync(
            string datasetId,
            string baselineSessionId,
            global::System.Collections.Generic.IList<string> comparisonSessionIds,
            string feedbackKey,
            global::System.AnyOf<object?, object?>? filters = default,
            int offset = 0,
            int limit = 100,
            global::System.AnyOf<string?, object?>? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.QueryFeedbackDelta
            {
                BaselineSessionId = baselineSessionId,
                ComparisonSessionIds = comparisonSessionIds,
                FeedbackKey = feedbackKey,
                Filters = filters,
                Offset = offset,
                Limit = limit,
                ComparativeExperimentId = comparativeExperimentId,
            };

            return await ReadDeltaAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}