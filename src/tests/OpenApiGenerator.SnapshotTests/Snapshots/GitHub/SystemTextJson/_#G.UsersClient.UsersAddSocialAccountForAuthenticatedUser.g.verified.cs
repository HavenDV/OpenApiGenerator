﻿//HintName: G.UsersClient.UsersAddSocialAccountForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersAddSocialAccountForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UsersAddSocialAccountForAuthenticatedUserRequest request);
        partial void PrepareUsersAddSocialAccountForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UsersAddSocialAccountForAuthenticatedUserRequest request);
        partial void ProcessUsersAddSocialAccountForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersAddSocialAccountForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add social accounts for the authenticated user<br/>
        /// Add one or more social accounts to the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SocialAccount>> UsersAddSocialAccountForAuthenticatedUserAsync(
            global::G.UsersAddSocialAccountForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUsersAddSocialAccountForAuthenticatedUserArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/user/social_accounts", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUsersAddSocialAccountForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUsersAddSocialAccountForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUsersAddSocialAccountForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.SocialAccount>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add social accounts for the authenticated user<br/>
        /// Add one or more social accounts to the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="accountUrls">
        /// Full URLs for the social media profiles to add.<br/>
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SocialAccount>> UsersAddSocialAccountForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> accountUrls,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UsersAddSocialAccountForAuthenticatedUserRequest
            {
                AccountUrls = accountUrls,
            };

            return await UsersAddSocialAccountForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}