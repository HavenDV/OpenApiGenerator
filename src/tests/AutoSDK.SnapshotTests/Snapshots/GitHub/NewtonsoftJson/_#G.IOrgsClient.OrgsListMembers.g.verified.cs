﻿//HintName: G.IOrgsClient.OrgsListMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization members<br/>
        /// List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> OrgsListMembersAsync(
            string org,
            global::G.OrgsListMembersFilter? filter = global::G.OrgsListMembersFilter.All,
            global::G.OrgsListMembersRole? role = global::G.OrgsListMembersRole.All,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}