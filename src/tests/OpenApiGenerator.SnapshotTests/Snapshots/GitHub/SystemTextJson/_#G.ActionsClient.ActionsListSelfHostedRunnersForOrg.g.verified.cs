﻿//HintName: G.ActionsClient.ActionsListSelfHostedRunnersForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// List self-hosted runners for an organization
        /// </summary>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsListSelfHostedRunnersForOrgResponse> ActionsListSelfHostedRunnersForOrgAsync(
            string name,
            string org,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/runners?name={name}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ActionsListSelfHostedRunnersForOrgResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}