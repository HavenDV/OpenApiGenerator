﻿//HintName: G.AnnotationQueuesClient.UpdateRunInAnnotationQueue.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareUpdateRunInAnnotationQueueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            ref string queueRunId,
            global::G.AnnotationQueueRunUpdateSchema request);
        partial void PrepareUpdateRunInAnnotationQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            string queueRunId,
            global::G.AnnotationQueueRunUpdateSchema request);
        partial void ProcessUpdateRunInAnnotationQueueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunInAnnotationQueueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateRunInAnnotationQueueAsync(
            string queueId,
            string queueRunId,
            global::G.AnnotationQueueRunUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRunInAnnotationQueueArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                queueRunId: ref queueRunId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/runs/{queueRunId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRunInAnnotationQueueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                queueRunId: queueRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRunInAnnotationQueueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRunInAnnotationQueueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateRunInAnnotationQueueAsync(
            string queueId,
            string queueRunId,
            global::System.AnyOf<global::System.DateTime, object?>? lastReviewedTime = default,
            global::System.AnyOf<global::System.DateTime, object?>? addedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.AnnotationQueueRunUpdateSchema
            {
                LastReviewedTime = lastReviewedTime,
                AddedAt = addedAt,
            };

            return await UpdateRunInAnnotationQueueAsync(
                queueId: queueId,
                queueRunId: queueRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}