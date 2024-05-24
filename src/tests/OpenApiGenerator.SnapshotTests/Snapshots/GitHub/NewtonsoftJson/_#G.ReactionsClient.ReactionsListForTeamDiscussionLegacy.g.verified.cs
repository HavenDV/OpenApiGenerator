﻿//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionLegacy.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        /// <summary>
        /// List reactions for a team discussion (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReactionsListForTeamDiscussionLegacyAsync(
            int teamId,
            int discussionNumber,
            ReactionsListForTeamDiscussionLegacyContent content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentValue = content switch
            {
                ReactionsListForTeamDiscussionLegacyContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionLegacyContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionLegacyContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionLegacyContent.Confused => "confused",
                ReactionsListForTeamDiscussionLegacyContent.Heart => "heart",
                ReactionsListForTeamDiscussionLegacyContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionLegacyContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionLegacyContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/teams/{teamId}/discussions/{discussionNumber}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}