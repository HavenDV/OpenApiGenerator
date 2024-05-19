﻿//HintName: G.Api.EndPoints.GenerateChatCompletion.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Generate the next message in a chat with a provided model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<GenerateChatCompletionResponse> GenerateChatCompletionAsync(
            GenerateChatCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/chat");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = global::Newtonsoft.Json.JsonConvert.DeserializeObject<GenerateChatCompletionResponse>(content) ??
                                       throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");

                yield return streamedResponse;
            }
        }

        /// <summary>
        /// Generate the next message in a chat with a provided model.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="format"></param>
        /// <param name="options"></param>
        /// <param name="stream"></param>
        /// <param name="keepAlive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<GenerateChatCompletionResponse> GenerateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<Message> messages,
            GenerateChatCompletionRequestFormat? format = default,
            RequestOptions? options = default,
            bool stream = default,
            int keepAlive = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new GenerateChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Format = format,
                Options = options,
                Stream = stream,
                KeepAlive = keepAlive,
            };

            var enumerable = GenerateChatCompletionAsync(
                request: request,
                cancellationToken: cancellationToken);

            await foreach (var response in enumerable)
            {
                yield return response;
            }
        }
    }
}