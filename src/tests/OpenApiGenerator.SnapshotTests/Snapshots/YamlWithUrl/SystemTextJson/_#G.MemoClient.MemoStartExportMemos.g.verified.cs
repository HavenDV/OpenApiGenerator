﻿//HintName: G.MemoClient.MemoStartExportMemos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        /// <summary>
        /// StartExportMemos.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="description"></param>
        /// <param name="extension"></param>
        /// <param name="includeCodes"></param>
        /// <param name="includeMedia"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="includeDescriptors"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task MemoStartExportMemosAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> memoIds,
            string description,
            string extension,
            bool includeCodes,
            bool includeMedia,
            bool includeExcerpts,
            bool includeDescriptors,
            string symKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/memo/startexportmemos?projectId={projectId}&{string.Join("&", memoIds.Select(static x => $"memoIds={x}"))}&description={description}&extension={extension}&includeCodes={includeCodes}&includeMedia={includeMedia}&includeExcerpts={includeExcerpts}&includeDescriptors={includeDescriptors}&symKey={symKey}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}