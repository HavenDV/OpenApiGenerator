﻿//HintName: G.PublicClient.ReadSharedDatasetRun.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string runId,
            ref string shareToken,
            ref bool excludeS3StoredAttributes);
        partial void PrepareReadSharedDatasetRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string runId,
            string shareToken,
            bool excludeS3StoredAttributes);
        partial void ProcessReadSharedDatasetRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDatasetRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Dataset Run<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunPublicDatasetSchema> ReadSharedDatasetRunAsync(
            string runId,
            string shareToken,
            bool excludeS3StoredAttributes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDatasetRunArguments(
                httpClient: _httpClient,
                runId: ref runId,
                shareToken: ref shareToken,
                excludeS3StoredAttributes: ref excludeS3StoredAttributes);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/{runId}?exclude_s3_stored_attributes={excludeS3StoredAttributes}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDatasetRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                runId: runId,
                shareToken: shareToken,
                excludeS3StoredAttributes: excludeS3StoredAttributes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedDatasetRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDatasetRunResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunPublicDatasetSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}