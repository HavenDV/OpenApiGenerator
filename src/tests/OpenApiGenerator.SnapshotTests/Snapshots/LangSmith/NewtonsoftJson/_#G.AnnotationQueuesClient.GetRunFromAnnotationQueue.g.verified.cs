﻿//HintName: G.AnnotationQueuesClient.GetRunFromAnnotationQueue.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareGetRunFromAnnotationQueueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            ref int index);
        partial void PrepareGetRunFromAnnotationQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            int index);
        partial void ProcessGetRunFromAnnotationQueueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRunFromAnnotationQueueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunSchemaWithAnnotationQueueInfo> GetRunFromAnnotationQueueAsync(
            string queueId,
            int index,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetRunFromAnnotationQueueArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                index: ref index);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/run/{index}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetRunFromAnnotationQueueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                index: index);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetRunFromAnnotationQueueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetRunFromAnnotationQueueResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunSchemaWithAnnotationQueueInfo?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}