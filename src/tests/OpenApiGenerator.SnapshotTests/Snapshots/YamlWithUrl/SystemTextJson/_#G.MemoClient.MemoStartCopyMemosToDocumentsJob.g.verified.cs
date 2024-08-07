﻿//HintName: G.MemoClient.MemoStartCopyMemosToDocumentsJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        /// <summary>
        /// StartCopyMemosToDocumentsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="memoIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task MemoStartCopyMemosToDocumentsJobAsync(
            string token,
            string projectId,
            string userId,
            global::System.Collections.Generic.IList<string> memoIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/memo/startcopymemostodocumentsjob?projectId={projectId}&userId={userId}&{string.Join("&", memoIds.Select(static x => $"memoIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}