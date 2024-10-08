﻿//HintName: G.IGistsClient.GistsUnstar.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Unstar a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> GistsUnstarAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}