﻿//HintName: G.TagClient.TagGetProjectTagsExportFileURLJobId.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        /// <summary>
        /// GetProjectTagsExportFileURLJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TagGetProjectTagsExportFileURLJobIdAsync(
            string token,
            string projectId,
            string fileExtension,
            bool includeExcerpts,
            string encryptedSymKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/tag/getprojecttagsexportfileurljobid?projectId={projectId}&fileExtension={fileExtension}&includeExcerpts={includeExcerpts}&encryptedSymKey={encryptedSymKey}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}