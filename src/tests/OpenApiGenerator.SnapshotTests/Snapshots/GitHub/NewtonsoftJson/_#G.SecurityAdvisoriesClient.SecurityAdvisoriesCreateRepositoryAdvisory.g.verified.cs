﻿//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesCreateRepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesCreateRepositoryAdvisoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.RepositoryAdvisoryCreate request);
        partial void PrepareSecurityAdvisoriesCreateRepositoryAdvisoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.RepositoryAdvisoryCreate request);
        partial void ProcessSecurityAdvisoriesCreateRepositoryAdvisoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesCreateRepositoryAdvisoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a repository security advisory<br/>
        /// Creates a new repository security advisory.<br/>
        /// In order to create a draft repository security advisory, the authenticated user must be a security manager or administrator of that repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            global::G.RepositoryAdvisoryCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSecurityAdvisoriesCreateRepositoryAdvisoryArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/security-advisories", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityAdvisoriesCreateRepositoryAdvisoryRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityAdvisoriesCreateRepositoryAdvisoryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityAdvisoriesCreateRepositoryAdvisoryResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryAdvisory?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository security advisory<br/>
        /// Creates a new repository security advisory.<br/>
        /// In order to create a draft repository security advisory, the authenticated user must be a security manager or administrator of that repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory impacts.
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="vulnerabilities">
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </param>
        /// <param name="cweIds">
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </param>
        /// <param name="credits">
        /// A list of users receiving credit for their participation in the security advisory.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </param>
        /// <param name="cvssVectorString">
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </param>
        /// <param name="startPrivateFork">
        /// Whether to create a temporary private fork of the repository to collaborate on a fix.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string summary,
            string description,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilities> vulnerabilities,
            string? cveId = default,
            global::System.Collections.Generic.IList<string?>? cweIds = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredits?>? credits = default,
            global::G.RepositoryAdvisoryCreateSeverity? severity = default,
            string? cvssVectorString = default,
            bool startPrivateFork = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RepositoryAdvisoryCreate
            {
                Summary = summary,
                Description = description,
                CveId = cveId,
                Vulnerabilities = vulnerabilities,
                CweIds = cweIds,
                Credits = credits,
                Severity = severity,
                CvssVectorString = cvssVectorString,
                StartPrivateFork = startPrivateFork,
            };

            return await SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}