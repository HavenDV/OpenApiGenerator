﻿//HintName: G.ActionsClient.ActionsGetWorkflowRunAttempt.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Get a workflow run attempt
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="attemptNumber"></param>
        /// <param name="excludePullRequests"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WorkflowRun> ActionsGetWorkflowRunAttemptAsync(
            string owner,
            string repo,
            int runId,
            int attemptNumber,
            bool excludePullRequests,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runs/{runId}/attempts/{attemptNumber}?exclude_pull_requests={excludePullRequests}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<WorkflowRun>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}