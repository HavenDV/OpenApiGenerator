﻿//HintName: G.ScheduleClient.CreateChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        /// <summary>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateChannelStreamScheduleSegmentResponse> CreateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            CreateChannelStreamScheduleSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/schedule/segment?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CreateChannelStreamScheduleSegmentResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="startTime"></param>
        /// <param name="timezone"></param>
        /// <param name="duration"></param>
        /// <param name="isRecurring"></param>
        /// <param name="categoryId"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateChannelStreamScheduleSegmentResponse> CreateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            global::System.DateTime startTime,
            string timezone,
            string duration,
            bool isRecurring = default,
            string? categoryId = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateChannelStreamScheduleSegmentBody
            {
                StartTime = startTime,
                Timezone = timezone,
                Duration = duration,
                IsRecurring = isRecurring,
                CategoryId = categoryId,
                Title = title,
            };

            return await CreateChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}