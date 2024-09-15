﻿//HintName: G.IProjectsClient.ProjectsListForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List user projects<br/>
        /// Lists projects for a user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Project>> ProjectsListForUserAsync(
            string username,
            global::G.ProjectsListForUserState? state = global::G.ProjectsListForUserState.Open,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}