﻿//HintName: G.ITracerSessionsClient.DeleteFilterView.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Delete Filter View<br/>
        /// Delete a specific filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFilterViewApiV1SessionsSessionIdViewsViewIdDeleteResponse> DeleteFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}