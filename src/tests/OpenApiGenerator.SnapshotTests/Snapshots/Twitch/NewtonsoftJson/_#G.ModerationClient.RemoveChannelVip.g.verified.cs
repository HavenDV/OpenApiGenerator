﻿//HintName: G.ModerationClient.RemoveChannelVip.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareRemoveChannelVipArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string broadcasterId);
        partial void PrepareRemoveChannelVipRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string broadcasterId);
        partial void ProcessRemoveChannelVipResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Removes the specified user as a VIP in the broadcaster’s channel.<br/>
        /// Removes the specified user as a VIP in the broadcaster’s channel.<br/>
        /// If the broadcaster is removing the user’s VIP status, the ID in the _broadcaster\_id_ query parameter must match the user ID in the access token; otherwise, if the user is removing their VIP status themselves, the ID in the _user\_id_ query parameter must match the user ID in the access token.<br/>
        /// **Rate Limits**: The broadcaster may remove a maximum of 10 VIPs within a 10-second window.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:vips** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task RemoveChannelVipAsync(
            string userId,
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRemoveChannelVipArguments(
                httpClient: _httpClient,
                userId: ref userId,
                broadcasterId: ref broadcasterId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/channels/vips?user_id={userId}&broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRemoveChannelVipRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                broadcasterId: broadcasterId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRemoveChannelVipResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}