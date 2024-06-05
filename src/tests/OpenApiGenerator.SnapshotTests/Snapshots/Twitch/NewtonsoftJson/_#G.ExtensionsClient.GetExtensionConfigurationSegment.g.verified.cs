﻿//HintName: G.ExtensionsClient.GetExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Gets the specified configuration segment from the specified extension.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="extensionId"></param>
        /// <param name="segment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetExtensionConfigurationSegmentResponse> GetExtensionConfigurationSegmentAsync(
            string broadcasterId,
            string extensionId,
            GetExtensionConfigurationSegmentSegment segment,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var segmentValue = segment switch
            {
                GetExtensionConfigurationSegmentSegment.Broadcaster => "broadcaster",
                GetExtensionConfigurationSegmentSegment.Developer => "developer",
                GetExtensionConfigurationSegmentSegment.Global => "global",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/extensions/configurations?broadcaster_id={broadcasterId}&extension_id={extensionId}&segment={segmentValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetExtensionConfigurationSegmentResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}