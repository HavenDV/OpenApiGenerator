﻿//HintName: G.OrgsClient.OrgsUpdatePatAccesses.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsUpdatePatAccessesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsUpdatePatAccessesRequest request);
        partial void PrepareOrgsUpdatePatAccessesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsUpdatePatAccessesRequest request);
        partial void ProcessOrgsUpdatePatAccessesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsUpdatePatAccessesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update the access to organization resources via fine-grained personal access tokens<br/>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsUpdatePatAccessesAsync(
            string org,
            global::G.OrgsUpdatePatAccessesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsUpdatePatAccessesArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/personal-access-tokens", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsUpdatePatAccessesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsUpdatePatAccessesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsUpdatePatAccessesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update the access to organization resources via fine-grained personal access tokens<br/>
        /// Updates the access organization members have to organization resources via fine-grained personal access tokens. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        /// <param name="patIds">
        /// The IDs of the fine-grained personal access tokens.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsUpdatePatAccessesAsync(
            string org,
            global::G.OrgsUpdatePatAccessesRequestAction action,
            global::System.Collections.Generic.IList<int> patIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsUpdatePatAccessesRequest
            {
                Action = action,
                PatIds = patIds,
            };

            return await OrgsUpdatePatAccessesAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}