﻿//HintName: G.SearchClient.SearchCode.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        /// <summary>
        /// Search code
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<SearchCodeResponse> SearchCodeAsync(
            string q,
            SearchCodeSort sort,
            SearchCodeOrder order,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sortValue = sort switch
            {
                SearchCodeSort.Indexed => "indexed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderValue = order switch
            {
                SearchCodeOrder.Desc => "desc",
                SearchCodeOrder.Asc => "asc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/search/code?q={q}&sort={sortValue}&order={orderValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<SearchCodeResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}