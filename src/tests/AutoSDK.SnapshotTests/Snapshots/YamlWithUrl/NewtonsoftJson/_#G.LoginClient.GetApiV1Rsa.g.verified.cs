﻿//HintName: G.LoginClient.GetApiV1Rsa.g.cs

#nullable enable

namespace G
{
    public partial class LoginClient
    {
        /// <summary>
        /// Returns RSA public information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RSAWriteKeyInfo> GetApiV1RsaAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/api/v1/rsa", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RSAWriteKeyInfo>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}