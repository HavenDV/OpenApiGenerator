﻿//HintName: G.GitClient.GitCreateCommit.g.cs

#nullable enable

namespace G
{
    public partial class GitClient
    {
        /// <summary>
        /// Create a commit
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GitCommit> GitCreateCommitAsync(
            string owner,
            string repo,
            GitCreateCommitRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/git/commits", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GitCommit?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a commit
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="parents"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="signature"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GitCommit> GitCreateCommitAsync(
            string owner,
            string repo,
            string message,
            string tree,
            global::System.Collections.Generic.IList<string?>? parents = default,
            GitCreateCommitRequestAuthor? author = default,
            GitCreateCommitRequestCommitter? committer = default,
            string? signature = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new GitCreateCommitRequest
            {
                Message = message,
                Tree = tree,
                Parents = parents,
                Author = author,
                Committer = committer,
                Signature = signature,
            };

            return await GitCreateCommitAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}