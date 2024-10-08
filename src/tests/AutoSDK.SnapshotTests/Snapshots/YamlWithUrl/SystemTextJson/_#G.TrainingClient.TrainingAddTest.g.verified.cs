﻿//HintName: G.TrainingClient.TrainingAddTest.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        /// <summary>
        /// AddTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="trainingTestType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdUserId"></param>
        /// <param name="exIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TrainingAddTestAsync(
            string token,
            string projectId,
            int trainingTestType,
            string title,
            string description,
            string createdUserId,
            global::System.Collections.Generic.IList<string> exIds,
            global::System.Collections.Generic.IList<string> tagIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/training/addtest?projectId={projectId}&trainingTestType={trainingTestType}&title={title}&description={description}&createdUserId={createdUserId}&{string.Join("&", exIds.Select(static x => $"exIds={x}"))}&{string.Join("&", tagIds.Select(static x => $"tagIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}