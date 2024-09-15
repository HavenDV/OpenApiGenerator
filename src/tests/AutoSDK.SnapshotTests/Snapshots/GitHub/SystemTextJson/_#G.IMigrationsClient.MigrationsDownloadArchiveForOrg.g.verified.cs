﻿//HintName: G.IMigrationsClient.MigrationsDownloadArchiveForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Download an organization migration archive<br/>
        /// Fetches the URL to a migration archive.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="migrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> MigrationsDownloadArchiveForOrgAsync(
            string org,
            int migrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}