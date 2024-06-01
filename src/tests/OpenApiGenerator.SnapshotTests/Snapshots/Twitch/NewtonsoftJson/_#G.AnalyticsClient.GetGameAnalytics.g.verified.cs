﻿//HintName: G.AnalyticsClient.GetGameAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        /// <summary>
        /// Gets an analytics report for one or more games.
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetGameAnalyticsResponse> GetGameAnalyticsAsync(
            string gameId,
            GetGameAnalyticsType type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var typeValue = type switch
            {
                GetGameAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/analytics/games?game_id={gameId}&type={typeValue}&started_at={startedAt}&ended_at={endedAt}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetGameAnalyticsResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}