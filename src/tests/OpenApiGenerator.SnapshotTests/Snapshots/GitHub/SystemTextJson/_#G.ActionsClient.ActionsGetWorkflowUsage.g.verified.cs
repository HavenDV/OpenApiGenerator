﻿//HintName: G.ActionsClient.ActionsGetWorkflowUsage.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Get workflow usage
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WorkflowUsage> ActionsGetWorkflowUsageAsync(
            string owner,
            string repo,
            object workflowId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/workflows/{workflowId}/timing", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<WorkflowUsage>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}