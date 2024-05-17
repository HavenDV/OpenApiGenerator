﻿//HintName: G.Api.EndPoints.Update_run_runs__run_id__patch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Update Run
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Update_run_runs__run_id__patchAsync(
            RunUpdateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: "/runs/{run_id}");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Update Run
        /// </summary>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Update_run_runs__run_id__patchAsync(
            global::System.DateTime endTime,
            string? error,
            object? inputs,
            object? outputs,
            global::System.Collections.Generic.IList<RunUpdateSchemaExtendedEvents?>? events,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RunUpdateSchemaExtended
            {
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
            };

            await Update_run_runs__run_id__patchAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}