﻿//HintName: G.TeamsClient.TeamsAddOrUpdateProjectPermissionsInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Add or update team project permissions
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamsAddOrUpdateProjectPermissionsInOrgResponse> TeamsAddOrUpdateProjectPermissionsInOrgAsync(
            string org,
            string teamSlug,
            int projectId,
            TeamsAddOrUpdateProjectPermissionsInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/teams/{teamSlug}/projects/{projectId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<TeamsAddOrUpdateProjectPermissionsInOrgResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add or update team project permissions
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="projectId"></param>
        /// <param name="permission"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamsAddOrUpdateProjectPermissionsInOrgResponse> TeamsAddOrUpdateProjectPermissionsInOrgAsync(
            string org,
            string teamSlug,
            int projectId,
            TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission? permission = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TeamsAddOrUpdateProjectPermissionsInOrgRequest
            {
                Permission = permission,
            };

            return await TeamsAddOrUpdateProjectPermissionsInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                projectId: projectId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}