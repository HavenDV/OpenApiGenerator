﻿//HintName: G.ResourceClient.ResourceUpdateTranscriptData.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// UpdateTranscriptData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="dataPath"></param>
        /// <param name="created"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ResourceUpdateTranscriptDataAsync(
            string token,
            string projectIdKey,
            string id,
            string creator,
            string projectId,
            string resourceId,
            string dataPath,
            global::System.DateTime created,
            string transcriptData,
            global::System.Collections.Generic.IList<TranscriptSyncItem> syncItems,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/resource/updatetranscriptdata?ProjectIdKey={projectIdKey}&Id={id}&Creator={creator}&ProjectId={projectId}&ResourceId={resourceId}&DataPath={dataPath}&Created={created}&transcriptData={transcriptData}&{string.Join("&", syncItems.Select(static x => $"syncItems={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}