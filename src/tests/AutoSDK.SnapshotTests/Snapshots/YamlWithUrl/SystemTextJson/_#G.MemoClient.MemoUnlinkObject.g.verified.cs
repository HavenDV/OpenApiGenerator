﻿//HintName: G.MemoClient.MemoUnlinkObject.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        /// <summary>
        /// UnlinkObject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task MemoUnlinkObjectAsync(
            string token,
            string projectId,
            string memoId,
            string resourceId,
            string excerptId,
            string descriptorId,
            string tagId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/memo/unlinkobject?projectId={projectId}&memoId={memoId}&resourceId={resourceId}&excerptId={excerptId}&descriptorId={descriptorId}&tagId={tagId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}