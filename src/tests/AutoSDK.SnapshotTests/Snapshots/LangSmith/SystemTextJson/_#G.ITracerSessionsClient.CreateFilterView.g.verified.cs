﻿//HintName: G.ITracerSessionsClient.CreateFilterView.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,
            global::G.FilterViewCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,
            string filterString,
            string displayName,
            global::G.AnyOf<string, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}