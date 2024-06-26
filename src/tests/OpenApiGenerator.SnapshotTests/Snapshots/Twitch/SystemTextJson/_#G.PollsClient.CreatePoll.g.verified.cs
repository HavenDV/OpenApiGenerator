﻿//HintName: G.PollsClient.CreatePoll.g.cs

#nullable enable

namespace G
{
    public partial class PollsClient
    {
        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// The poll begins as soon as it’s created. You may run only one poll at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePollResponse> CreatePollAsync(
            global::G.CreatePollBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + "/polls", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreatePollResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// The poll begins as soon as it’s created. You may run only one poll at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title"></param>
        /// <param name="choices"></param>
        /// <param name="duration"></param>
        /// <param name="channelPointsVotingEnabled"></param>
        /// <param name="channelPointsPerVote"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePollResponse> CreatePollAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePollBodyChoices> choices,
            int duration,
            bool channelPointsVotingEnabled = default,
            int channelPointsPerVote = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreatePollBody
            {
                BroadcasterId = broadcasterId,
                Title = title,
                Choices = choices,
                Duration = duration,
                ChannelPointsVotingEnabled = channelPointsVotingEnabled,
                ChannelPointsPerVote = channelPointsPerVote,
            };

            return await CreatePollAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}