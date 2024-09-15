﻿//HintName: G.IActionsClient.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove all custom labels from a self-hosted runner for an organization<br/>
        /// Remove all custom labels from a self-hosted runner configured in an<br/>
        /// organization. Returns the remaining read-only labels from the runner.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrgResponse> ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}