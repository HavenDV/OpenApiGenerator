﻿//HintName: G.StreamsClient.GetStreamMarkers.g.cs

#nullable enable

namespace G
{
    public partial class StreamsClient
    {
        /// <summary>
        /// Gets a list of markers from the user’s most recent stream or from the specified VOD/video.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="videoId"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetStreamMarkersResponse> GetStreamMarkersAsync(
            string userId,
            string videoId,
            string first,
            string before,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/streams/markers?user_id={userId}&video_id={videoId}&first={first}&before={before}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetStreamMarkersResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}