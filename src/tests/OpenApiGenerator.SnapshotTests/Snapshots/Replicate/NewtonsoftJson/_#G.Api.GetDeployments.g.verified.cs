﻿//HintName: G.Api.GetDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGetDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deploymentOwner,
            ref string deploymentName);
        partial void PrepareGetDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deploymentOwner,
            string deploymentName);
        partial void ProcessGetDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a deployment<br/>
        /// Get information about a deployment by name including the current release.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/deployments/replicate/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 1,<br/>
        ///     "model": "stability-ai/sdxl",<br/>
        ///     "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///     "created_by": {<br/>
        ///       "type": "organization",<br/>
        ///       "username": "acme",<br/>
        ///       "name": "Acme Corp, Inc.",<br/>
        ///       "github_url": "https://github.com/acme",<br/>
        ///     },<br/>
        ///     "configuration": {<br/>
        ///       "hardware": "gpu-t4",<br/>
        ///       "min_instances": 1,<br/>
        ///       "max_instances": 5<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetDeploymentsResponse> GetDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDeploymentsArguments(
                httpClient: _httpClient,
                deploymentOwner: ref deploymentOwner,
                deploymentName: ref deploymentName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/deployments/{deploymentOwner}/{deploymentName}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDeploymentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDeploymentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDeploymentsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetDeploymentsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}