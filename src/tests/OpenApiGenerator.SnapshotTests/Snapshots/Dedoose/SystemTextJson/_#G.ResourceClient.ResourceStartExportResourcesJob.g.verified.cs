﻿//HintName: G.ResourceClient.ResourceStartExportResourcesJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceStartExportResourcesJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            global::System.Collections.Generic.IList<string> resourceIds,
            ref bool includeDescriptorInfo,
            ref bool includeCodeCounts);
        partial void PrepareResourceStartExportResourcesJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> resourceIds,
            bool includeDescriptorInfo,
            bool includeCodeCounts);
        partial void ProcessResourceStartExportResourcesJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceStartExportResourcesJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportResourcesJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceStartExportResourcesJobAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> resourceIds,
            bool includeDescriptorInfo,
            bool includeCodeCounts,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceStartExportResourcesJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                resourceIds: resourceIds,
                includeDescriptorInfo: ref includeDescriptorInfo,
                includeCodeCounts: ref includeCodeCounts);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/startexportresourcesjob?projectId={projectId}&{string.Join("&", resourceIds.Select(static x => $"resourceIds={x}"))}&includeDescriptorInfo={includeDescriptorInfo}&includeCodeCounts={includeCodeCounts}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceStartExportResourcesJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                resourceIds: resourceIds,
                includeDescriptorInfo: includeDescriptorInfo,
                includeCodeCounts: includeCodeCounts);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceStartExportResourcesJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceStartExportResourcesJobResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}