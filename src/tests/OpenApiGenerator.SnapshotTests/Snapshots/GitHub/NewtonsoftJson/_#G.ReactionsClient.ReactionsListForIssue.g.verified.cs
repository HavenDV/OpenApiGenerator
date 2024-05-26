﻿//HintName: G.ReactionsClient.ReactionsListForIssue.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        /// <summary>
        /// List reactions for an issue
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReactionsListForIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            ReactionsListForIssueContent content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentValue = content switch
            {
                ReactionsListForIssueContent.Plus1 => "+1",
                ReactionsListForIssueContent.Minus1 => "-1",
                ReactionsListForIssueContent.Laugh => "laugh",
                ReactionsListForIssueContent.Confused => "confused",
                ReactionsListForIssueContent.Heart => "heart",
                ReactionsListForIssueContent.Hooray => "hooray",
                ReactionsListForIssueContent.Rocket => "rocket",
                ReactionsListForIssueContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/issues/{issueNumber}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}