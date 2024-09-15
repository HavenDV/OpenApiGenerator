﻿//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Cohere Platform is centered around models.<br/>
    /// Each model has a different amount of power (i.e. parameters), to be used for different tasks.<br/>
    /// Cohere also supports finetuning of baseline models to improve performance on downstream tasks or to teach the model large quantities of information which cannot be extracted with few-shot learning or prompt engineering.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// production
        /// </summary>
        public const string BaseUrl = "https://api.cohere.com";

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Datasets API
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Connectors API
        /// </summary>
        public ConnectorsClient Connectors { get; }

        /// <summary>
        /// Embed Jobs API
        /// </summary>
        public EmbedJobsClient EmbedJobs { get; }

        /// <summary>
        /// Finetuning API (Beta)
        /// </summary>
        public FinetuningClient Finetuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

    }
}