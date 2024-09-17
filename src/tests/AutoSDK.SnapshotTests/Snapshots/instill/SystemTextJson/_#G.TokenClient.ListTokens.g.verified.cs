﻿//HintName: G.TokenClient.ListTokens.g.cs

#nullable enable

namespace G
{
    public partial class TokenClient
    {
        partial void PrepareListTokensArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? pageToken);
        partial void PrepareListTokensRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? pageToken);
        partial void ProcessListTokensResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTokensResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List API tokens<br/>
        /// Returns a paginated list of the API tokens of the authenticated user.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListTokensResponse> ListTokensAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTokensArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                pageToken: ref pageToken);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/tokens?pageSize={pageSize}&pageToken={pageToken}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTokensRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                pageToken: pageToken);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTokensResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTokensResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListTokensResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}