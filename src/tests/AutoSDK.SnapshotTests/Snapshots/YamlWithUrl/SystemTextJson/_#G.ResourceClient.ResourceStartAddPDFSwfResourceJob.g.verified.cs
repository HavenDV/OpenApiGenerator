﻿//HintName: G.ResourceClient.ResourceStartAddPDFSwfResourceJob.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// StartAddPDFSwfResourceJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="fileUri"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ResourceStartAddPDFSwfResourceJobAsync(
            string token,
            string projectId,
            string title,
            string fileUri,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/resource/startaddpdfswfresourcejob?projectId={projectId}&title={title}&fileUri={fileUri}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}