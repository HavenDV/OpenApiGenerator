﻿//HintName: G.DescriptorClient.DescriptorUpdateDescriptorSet.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        /// <summary>
        /// UpdateDescriptorSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createStamp"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DescriptorSet> DescriptorUpdateDescriptorSetAsync(
            string token,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string description,
            global::System.DateTime createStamp,
            string createdByUserId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/descriptor/updatedescriptorset?ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&Description={description}&CreateStamp={createStamp}&CreatedByUserId={createdByUserId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<DescriptorSet>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}