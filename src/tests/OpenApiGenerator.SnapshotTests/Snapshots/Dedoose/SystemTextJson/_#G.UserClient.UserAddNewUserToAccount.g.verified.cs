﻿//HintName: G.UserClient.UserAddNewUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserAddNewUserToAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string username,
            ref string firstName,
            ref string lastName,
            ref string email,
            ref string phone,
            ref string encryptedPass,
            ref string groupId);
        partial void PrepareUserAddNewUserToAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            string groupId);
        partial void ProcessUserAddNewUserToAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserAddNewUserToAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UserServiceAddNewUserToAccountControllerOutput> UserAddNewUserToAccountAsync(
            string token,
            string projectId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserAddNewUserToAccountArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                username: ref username,
                firstName: ref firstName,
                lastName: ref lastName,
                email: ref email,
                phone: ref phone,
                encryptedPass: ref encryptedPass,
                groupId: ref groupId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/addnewusertoaccount?projectId={projectId}&username={username}&firstName={firstName}&lastName={lastName}&email={email}&phone={phone}&encryptedPass={encryptedPass}&groupId={groupId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserAddNewUserToAccountRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                username: username,
                firstName: firstName,
                lastName: lastName,
                email: email,
                phone: phone,
                encryptedPass: encryptedPass,
                groupId: groupId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserAddNewUserToAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserAddNewUserToAccountResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserServiceAddNewUserToAccountControllerOutput?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}