﻿//HintName: G.IRunClient.GroupRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GroupRunsApiV1RunsGroupPostResponse> GroupRunsAsync(
            global::G.RunGroupRequest request,
            global::G.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Group Runs<br/>
        /// Get runs grouped by an expression
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="filter"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GroupRunsApiV1RunsGroupPostResponse> GroupRunsAsync(
            global::System.Guid sessionId,
            global::G.AnyOf<string, object>? accept = default,
            global::G.RunGroupBy groupBy = default,
            global::G.AnyOf<string, object>? filter = default,
            global::G.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}