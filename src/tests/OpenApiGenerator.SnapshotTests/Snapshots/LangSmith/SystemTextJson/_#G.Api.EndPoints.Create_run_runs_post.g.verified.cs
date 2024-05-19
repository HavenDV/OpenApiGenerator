﻿//HintName: G.Api.EndPoints.Create_run_runs_post.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create Run
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Create_run_runs_postAsync(
            RunCreateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/runs");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create Run
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="executionOrder"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="manifestId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="childRuns"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Create_run_runs_postAsync(
            string name,
            object? inputs,
            string runType,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            RunCreateSchemaExtendedExtra? extra,
            string? error,
            int executionOrder,
            RunCreateSchemaExtendedSerialized? serialized,
            object? outputs,
            string? parentRunId,
            string? manifestId,
            global::System.Collections.Generic.IList<RunCreateSchemaExtendedEvents?>? events,
            global::System.Collections.Generic.IList<string?>? tags,
            string? id,
            string? sessionId,
            string? sessionName,
            global::System.Collections.Generic.IList<RunCreateSchema>? childRuns,
            string? referenceExampleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RunCreateSchemaExtended
            {
                Name = name,
                Inputs = inputs,
                RunType = runType,
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Error = error,
                ExecutionOrder = executionOrder,
                Serialized = serialized,
                Outputs = outputs,
                ParentRunId = parentRunId,
                ManifestId = manifestId,
                Events = events,
                Tags = tags,
                Id = id,
                SessionId = sessionId,
                SessionName = sessionName,
                ChildRuns = childRuns,
                ReferenceExampleId = referenceExampleId,
            };

            await Create_run_runs_postAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}