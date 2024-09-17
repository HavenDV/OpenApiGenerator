﻿//HintName: G.IAnnotationQueuesClient.GetAnnotationQueues.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Annotation Queues
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnnotationQueueSchemaWithSize>> GetAnnotationQueuesAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ids = default,
            global::G.AnyOf<string, object>? name = default,
            global::G.AnyOf<string, object>? nameContains = default,
            int? offset = 0,
            int? limit = 100,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}