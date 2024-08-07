﻿//HintName: G.DescriptorClient.DescriptorStartExportDescriptorsJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        /// <summary>
        /// StartExportDescriptorsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DescriptorStartExportDescriptorsJobAsync(
            string token,
            string projectId,
            string setId,
            global::System.Collections.Generic.IList<string> descriptorIds,
            string fileExtension,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/descriptor/startexportdescriptorsjob?projectId={projectId}&setId={setId}&{string.Join("&", descriptorIds.Select(static x => $"descriptorIds={x}"))}&fileExtension={fileExtension}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}