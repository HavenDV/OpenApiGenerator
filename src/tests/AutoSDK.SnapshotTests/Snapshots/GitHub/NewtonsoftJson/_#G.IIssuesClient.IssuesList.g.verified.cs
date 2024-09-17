﻿//HintName: G.IIssuesClient.IssuesList.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List issues assigned to the authenticated user<br/>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, member<br/>
        /// repositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are not<br/>
        /// necessarily assigned to you.<br/>
        /// **Note**: GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this<br/>
        /// reason, "Issues" endpoints may return both issues and pull requests in the response. You can identify pull requests by<br/>
        /// the `pull_request` key. Be aware that the `id` of a pull request returned from "Issues" endpoints will be an _issue id_. To find out the pull<br/>
        /// request id, use the "[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)" endpoint.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="filter">
        /// Default Value: assigned
        /// </param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="labels"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="since"></param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Issue>> IssuesListAsync(
            global::G.IssuesListFilter? filter = global::G.IssuesListFilter.Assigned,
            global::G.IssuesListState? state = global::G.IssuesListState.Open,
            string? labels = default,
            global::G.IssuesListSort? sort = global::G.IssuesListSort.Created,
            global::G.IssuesListDirection? direction = global::G.IssuesListDirection.Desc,
            global::System.DateTime? since = default,
            bool? collab = default,
            bool? orgs = default,
            bool? owned = default,
            bool? pulls = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}