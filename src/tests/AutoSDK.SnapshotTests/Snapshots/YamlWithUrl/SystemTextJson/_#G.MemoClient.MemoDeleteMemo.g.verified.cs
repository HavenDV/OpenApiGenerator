﻿//HintName: G.MemoClient.MemoDeleteMemo.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        /// <summary>
        /// DeleteMemo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="createdUserId"></param>
        /// <param name="lastEditUserId"></param>
        /// <param name="createStamp"></param>
        /// <param name="lastEditStamp"></param>
        /// <param name="folderId"></param>
        /// <param name="dataURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Memo> MemoDeleteMemoAsync(
            string token,
            string projectIdKey,
            string id,
            string projectId,
            string title,
            string createdUserId,
            string lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            string folderId,
            string dataURI,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/memo/deletememo?ProjectIdKey={projectIdKey}&Id={id}&ProjectId={projectId}&Title={title}&CreatedUserId={createdUserId}&LastEditUserId={lastEditUserId}&CreateStamp={createStamp}&LastEditStamp={lastEditStamp}&FolderId={folderId}&DataURI={dataURI}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Memo>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}