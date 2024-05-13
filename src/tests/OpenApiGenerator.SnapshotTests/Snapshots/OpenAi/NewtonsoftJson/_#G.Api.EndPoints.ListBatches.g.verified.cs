﻿//HintName: G.Api.EndPoints.ListBatches.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// List your organization's batches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListBatchesResponse> ListBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: "/batches");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ListBatchesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}