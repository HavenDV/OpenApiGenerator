﻿//HintName: G.IWebhooksClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook events are how the **HeyGen** notifies your _endpoints_ when a variety of interactions or events happen, including when avatar video processing _succeeds_ or _fails_. Webhook events are sent by HeyGen as POST requests to your webhook endpoint.<br/>
    /// **Guide**: [https://docs.heygen.com/docs/using-heygens-webhook-events](https://docs.heygen.com/docs/using-heygens-webhook-events)**Reference**: [https://docs.heygen.com/reference/add-a-webhook-endpoint](https://docs.heygen.com/reference/add-a-webhook-endpoint)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IWebhooksClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.heygen.com";

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}