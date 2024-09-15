﻿//HintName: G.IWorkspacesClient.ListTagKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Tag Keys
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TagKey>> ListTagKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}