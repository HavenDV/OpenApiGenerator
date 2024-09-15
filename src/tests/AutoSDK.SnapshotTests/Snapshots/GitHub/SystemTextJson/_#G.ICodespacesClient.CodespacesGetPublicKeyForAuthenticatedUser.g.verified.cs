﻿//HintName: G.ICodespacesClient.CodespacesGetPublicKeyForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Get public key for the authenticated user<br/>
        /// Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets.<br/>
        /// The authenticated user must have Codespaces access to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesUserPublicKey> CodespacesGetPublicKeyForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}