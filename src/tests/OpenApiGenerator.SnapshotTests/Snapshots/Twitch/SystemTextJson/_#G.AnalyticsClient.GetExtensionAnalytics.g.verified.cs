﻿//HintName: G.AnalyticsClient.GetExtensionAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        /// <summary>
        /// Gets an analytics report for one or more extensions.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionAnalyticsResponse> GetExtensionAnalyticsAsync(
            string extensionId,
            global::G.GetExtensionAnalyticsType type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/analytics/extensions?extension_id={extensionId}&type={type}&started_at={startedAt}&ended_at={endedAt}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetExtensionAnalyticsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}