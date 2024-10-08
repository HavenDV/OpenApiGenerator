﻿//HintName: G.MemoClient.MemoStartExportMemosXML.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoStartExportMemosXMLArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds,
            ref int? codeSelection,
            ref int? mediaSelection,
            ref int? excerptsSelection,
            ref int? descriptorsSelection,
            ref string? symKey);
        partial void PrepareMemoStartExportMemosXMLRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds,
            int? codeSelection,
            int? mediaSelection,
            int? excerptsSelection,
            int? descriptorsSelection,
            string? symKey);
        partial void ProcessMemoStartExportMemosXMLResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoStartExportMemosXMLResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportMemosXML.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="codeSelection"></param>
        /// <param name="mediaSelection"></param>
        /// <param name="excerptsSelection"></param>
        /// <param name="descriptorsSelection"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> MemoStartExportMemosXMLAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds = default,
            int? codeSelection = default,
            int? mediaSelection = default,
            int? excerptsSelection = default,
            int? descriptorsSelection = default,
            string? symKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoStartExportMemosXMLArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                memoIds: memoIds,
                codeSelection: ref codeSelection,
                mediaSelection: ref mediaSelection,
                excerptsSelection: ref excerptsSelection,
                descriptorsSelection: ref descriptorsSelection,
                symKey: ref symKey);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/memo/startexportmemosxml",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("memoIds", memoIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("codeSelection", codeSelection?.ToString()) 
                .AddOptionalParameter("mediaSelection", mediaSelection?.ToString()) 
                .AddOptionalParameter("excerptsSelection", excerptsSelection?.ToString()) 
                .AddOptionalParameter("descriptorsSelection", descriptorsSelection?.ToString()) 
                .AddOptionalParameter("symKey", symKey) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoStartExportMemosXMLRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                memoIds: memoIds,
                codeSelection: codeSelection,
                mediaSelection: mediaSelection,
                excerptsSelection: excerptsSelection,
                descriptorsSelection: descriptorsSelection,
                symKey: symKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoStartExportMemosXMLResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoStartExportMemosXMLResponseContent(
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

            return __content;
        }
    }
}