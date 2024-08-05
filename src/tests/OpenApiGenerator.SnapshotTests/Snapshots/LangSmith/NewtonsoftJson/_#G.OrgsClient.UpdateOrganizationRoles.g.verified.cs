﻿//HintName: G.OrgsClient.UpdateOrganizationRoles.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateOrganizationRolesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string roleId,
            global::G.UpdateRoleRequest request);
        partial void PrepareUpdateOrganizationRolesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string roleId,
            global::G.UpdateRoleRequest request);
        partial void ProcessUpdateOrganizationRolesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateOrganizationRolesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Role> UpdateOrganizationRolesAsync(
            string roleId,
            global::G.UpdateRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateOrganizationRolesArguments(
                httpClient: _httpClient,
                roleId: ref roleId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/roles/{roleId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateOrganizationRolesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                roleId: roleId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateOrganizationRolesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateOrganizationRolesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Role?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Role> UpdateOrganizationRolesAsync(
            string roleId,
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateRoleRequest
            {
                DisplayName = displayName,
                Description = description,
                Permissions = permissions,
            };

            return await UpdateOrganizationRolesAsync(
                roleId: roleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}