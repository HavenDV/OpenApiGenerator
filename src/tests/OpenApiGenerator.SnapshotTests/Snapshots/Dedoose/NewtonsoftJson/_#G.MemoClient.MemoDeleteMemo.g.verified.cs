﻿//HintName: G.MemoClient.MemoDeleteMemo.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoDeleteMemoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectIdKey,
            ref string id,
            ref string projectId,
            ref string title,
            ref string createdUserId,
            ref string lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            ref string folderId,
            ref string dataURI);
        partial void PrepareMemoDeleteMemoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
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
            string dataURI);
        partial void ProcessMemoDeleteMemoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoDeleteMemoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.Memo> MemoDeleteMemoAsync(
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
            PrepareArguments(
                client: _httpClient);
            PrepareMemoDeleteMemoArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                projectId: ref projectId,
                title: ref title,
                createdUserId: ref createdUserId,
                lastEditUserId: ref lastEditUserId,
                createStamp: createStamp,
                lastEditStamp: lastEditStamp,
                folderId: ref folderId,
                dataURI: ref dataURI);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/deletememo?ProjectIdKey={projectIdKey}&Id={id}&ProjectId={projectId}&Title={title}&CreatedUserId={createdUserId}&LastEditUserId={lastEditUserId}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&LastEditStamp={lastEditStamp:yyyy-MM-ddTHH:mm:ssZ}&FolderId={folderId}&DataURI={dataURI}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoDeleteMemoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                projectId: projectId,
                title: title,
                createdUserId: createdUserId,
                lastEditUserId: lastEditUserId,
                createStamp: createStamp,
                lastEditStamp: lastEditStamp,
                folderId: folderId,
                dataURI: dataURI);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoDeleteMemoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoDeleteMemoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Memo?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}