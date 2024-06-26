﻿//HintName: G.ActionsClient.ActionsUpdateRepoVariable.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Update a repository variable
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateRepoVariableAsync(
            string owner,
            string repo,
            string name,
            ActionsUpdateRepoVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/variables/{name}", global::System.UriKind.RelativeOrAbsolute));
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
        /// Update a repository variable
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateRepoVariableAsync(
            string owner,
            string repo,
            string name,
            string? name = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsUpdateRepoVariableRequest
            {
                Name = name,
                Value = value,
            };

            await ActionsUpdateRepoVariableAsync(
                owner: owner,
                repo: repo,
                name: name,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}