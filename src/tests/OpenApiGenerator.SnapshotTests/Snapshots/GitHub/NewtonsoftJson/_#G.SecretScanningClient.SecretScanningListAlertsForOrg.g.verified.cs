﻿//HintName: G.SecretScanningClient.SecretScanningListAlertsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<OrganizationSecretScanningAlert>> SecretScanningListAlertsForOrgAsync(
            string org,
            SecretScanningListAlertsForOrgState state,
            string secretType,
            string resolution,
            SecretScanningListAlertsForOrgSort sort,
            SecretScanningListAlertsForOrgDirection direction,
            int page,
            int perPage,
            string before,
            string after,
            string validity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var stateValue = state switch
            {
                SecretScanningListAlertsForOrgState.Open => "open",
                SecretScanningListAlertsForOrgState.Resolved => "resolved",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                SecretScanningListAlertsForOrgSort.Created => "created",
                SecretScanningListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                SecretScanningListAlertsForOrgDirection.Asc => "asc",
                SecretScanningListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/secret-scanning/alerts?state={stateValue}&secret_type={secretType}&resolution={resolution}&sort={sortValue}&direction={directionValue}&page={page}&per_page={perPage}&before={before}&after={after}&validity={validity}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<OrganizationSecretScanningAlert>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}