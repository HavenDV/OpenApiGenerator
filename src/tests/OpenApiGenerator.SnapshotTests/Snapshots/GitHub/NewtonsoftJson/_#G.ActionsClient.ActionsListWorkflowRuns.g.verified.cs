﻿//HintName: G.ActionsClient.ActionsListWorkflowRuns.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// List workflow runs for a workflow
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="@event"></param>
        /// <param name="status"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsListWorkflowRunsAsync(
            string owner,
            string repo,
            object workflowId,
            string actor,
            string branch,
            string @event,
            ActionsListWorkflowRunsStatus status,
            int perPage,
            int page,
            global::System.DateTime created,
            bool excludePullRequests,
            int checkSuiteId,
            string headSha,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                ActionsListWorkflowRunsStatus.Completed => "completed",
                ActionsListWorkflowRunsStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsStatus.Failure => "failure",
                ActionsListWorkflowRunsStatus.Neutral => "neutral",
                ActionsListWorkflowRunsStatus.Skipped => "skipped",
                ActionsListWorkflowRunsStatus.Stale => "stale",
                ActionsListWorkflowRunsStatus.Success => "success",
                ActionsListWorkflowRunsStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsStatus.Queued => "queued",
                ActionsListWorkflowRunsStatus.Requested => "requested",
                ActionsListWorkflowRunsStatus.Waiting => "waiting",
                ActionsListWorkflowRunsStatus.Pending => "pending",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs?actor={actor}&branch={branch}&event={@event}&status={statusValue}&per_page={perPage}&page={page}&created={created}&exclude_pull_requests={excludePullRequests}&check_suite_id={checkSuiteId}&head_sha={headSha}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}