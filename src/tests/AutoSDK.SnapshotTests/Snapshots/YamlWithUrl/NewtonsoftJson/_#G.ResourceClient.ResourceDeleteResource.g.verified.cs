﻿//HintName: G.ResourceClient.ResourceDeleteResource.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// DeleteResource.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="dataPath"></param>
        /// <param name="length"></param>
        /// <param name="createStamp"></param>
        /// <param name="createByUserIDL"></param>
        /// <param name="isDataLocked"></param>
        /// <param name="metaData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Resource> ResourceDeleteResourceAsync(
            string token,
            string currentProjectId,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string description,
            int type,
            string dataPath,
            int length,
            global::System.DateTime createStamp,
            string createByUserIDL,
            bool isDataLocked,
            string metaData,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/resource/deleteresource?currentProjectId={currentProjectId}&ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&Description={description}&Type={type}&DataPath={dataPath}&Length={length}&CreateStamp={createStamp}&CreateByUserIDL={createByUserIDL}&IsDataLocked={isDataLocked}&MetaData={metaData}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Resource>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}