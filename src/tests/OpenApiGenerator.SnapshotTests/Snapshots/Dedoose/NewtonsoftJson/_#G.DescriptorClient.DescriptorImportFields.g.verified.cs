﻿//HintName: G.DescriptorClient.DescriptorImportFields.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorImportFieldsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            ref string existingSetId,
            ref string newSetTitle);
        partial void PrepareDescriptorImportFieldsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            string existingSetId,
            string newSetTitle);
        partial void ProcessDescriptorImportFieldsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorImportFieldsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ImportFields.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> DescriptorImportFieldsAsync(
            string token,
            string projectId,
            string userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            string existingSetId,
            string newSetTitle,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorImportFieldsArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                fieldInfos: fieldInfos,
                existingSetId: ref existingSetId,
                newSetTitle: ref newSetTitle);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/importfields?projectId={projectId}&userId={userId}&{string.Join("&", fieldInfos.Select(static x => $"fieldInfos={x}"))}&existingSetId={existingSetId}&newSetTitle={newSetTitle}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorImportFieldsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                fieldInfos: fieldInfos,
                existingSetId: existingSetId,
                newSetTitle: newSetTitle);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorImportFieldsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorImportFieldsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}