﻿//HintName: G.UserClient.UserGetCurrentUserPendingInvitations.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserGetCurrentUserPendingInvitationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token);
        partial void PrepareUserGetCurrentUserPendingInvitationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token);
        partial void ProcessUserGetCurrentUserPendingInvitationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserGetCurrentUserPendingInvitationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetCurrentUserPendingInvitations.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserInvitation>> UserGetCurrentUserPendingInvitationsAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserGetCurrentUserPendingInvitationsArguments(
                httpClient: _httpClient,
                token: ref token);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/user/getcurrentuserpendinginvitations", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserGetCurrentUserPendingInvitationsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserGetCurrentUserPendingInvitationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserGetCurrentUserPendingInvitationsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.UserInvitation>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}