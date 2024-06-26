﻿//HintName: G.ReposClient.ReposUpdateReleaseAsset.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a release asset
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ReleaseAsset> ReposUpdateReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            ReposUpdateReleaseAssetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/releases/assets/{assetId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ReleaseAsset?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a release asset
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ReleaseAsset> ReposUpdateReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            string? name = default,
            string? label = default,
            string? state = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateReleaseAssetRequest
            {
                Name = name,
                Label = label,
                State = state,
            };

            return await ReposUpdateReleaseAssetAsync(
                owner: owner,
                repo: repo,
                assetId: assetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}