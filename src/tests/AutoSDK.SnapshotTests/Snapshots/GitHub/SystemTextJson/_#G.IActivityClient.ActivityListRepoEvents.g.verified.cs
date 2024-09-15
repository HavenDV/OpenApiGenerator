﻿//HintName: G.IActivityClient.ActivityListRepoEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List repository events<br/>
        /// **Note**: This API is not built to serve real-time use cases. Depending on the time of day, event latency can be anywhere from 30s to 6h.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Event>> ActivityListRepoEventsAsync(
            string owner,
            string repo,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}