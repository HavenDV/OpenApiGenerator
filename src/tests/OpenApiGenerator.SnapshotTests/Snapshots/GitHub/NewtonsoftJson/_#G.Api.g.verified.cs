﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub's v3 REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.github.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::Newtonsoft.Json.JsonSerializerSettings _jsonSerializerOptions;


        /// <summary>
        /// Endpoints to manage GitHub Actions using the REST API.
        /// </summary>
        public ActionsClient Actions => new ActionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Activity APIs provide access to notifications, subscriptions, and timelines.
        /// </summary>
        public ActivityClient Activity => new ActivityClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Information for integrations and installations.
        /// </summary>
        public AppsClient Apps => new AppsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Monitor charges and usage from Actions and Packages.
        /// </summary>
        public BillingClient Billing => new BillingClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Rich interactions with checks run by your integrations.
        /// </summary>
        public ChecksClient Checks => new ChecksClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Retrieve code scanning alerts from a repository.
        /// </summary>
        public CodeScanningClient CodeScanning => new CodeScanningClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Insight into codes of conduct for your communities.
        /// </summary>
        public CodesOfConductClient CodesOfConduct => new CodesOfConductClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// List emojis available to use on GitHub.
        /// </summary>
        public EmojisClient Emojis => new EmojisClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to manage Dependabot.
        /// </summary>
        public DependabotClient Dependabot => new DependabotClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to access Dependency Graph features.
        /// </summary>
        public DependencyGraphClient DependencyGraph => new DependencyGraphClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// View, modify your gists.
        /// </summary>
        public GistsClient Gists => new GistsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Raw Git functionality.
        /// </summary>
        public GitClient Git => new GitClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// View gitignore templates
        /// </summary>
        public GitignoreClient Gitignore => new GitignoreClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Issues.
        /// </summary>
        public IssuesClient Issues => new IssuesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// View various OSS licenses.
        /// </summary>
        public LicensesClient Licenses => new LicensesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Render GitHub flavored markdown
        /// </summary>
        public MarkdownClient Markdown => new MarkdownClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Merge Queues.
        /// </summary>
        public MergeQueueClient MergeQueue => new MergeQueueClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints that give information about the API.
        /// </summary>
        public MetaClient Meta => new MetaClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Move projects to or from GitHub.
        /// </summary>
        public MigrationsClient Migrations => new MigrationsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to manage GitHub OIDC configuration using the REST API.
        /// </summary>
        public OidcClient Oidc => new OidcClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Orgs.
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Manage packages for authenticated users and organizations.
        /// </summary>
        public PackagesClient Packages => new PackagesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Projects.
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Pull Requests.
        /// </summary>
        public PullsClient Pulls => new PullsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Check your current rate limit status
        /// </summary>
        public RateLimitClient RateLimit => new RateLimitClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with reactions to various GitHub entities.
        /// </summary>
        public ReactionsClient Reactions => new ReactionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Repos.
        /// </summary>
        public ReposClient Repos => new ReposClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Look for stuff on GitHub.
        /// </summary>
        public SearchClient Search => new SearchClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Retrieve secret scanning alerts from a repository.
        /// </summary>
        public SecretScanningClient SecretScanning => new SecretScanningClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Teams.
        /// </summary>
        public TeamsClient Teams => new TeamsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with and view information about users and also current user.
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to manage Codespaces using the REST API.
        /// </summary>
        public CodespacesClient Codespaces => new CodespacesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to manage Copilot using the REST API.
        /// </summary>
        public CopilotClient Copilot => new CopilotClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Manage security advisories.
        /// </summary>
        public SecurityAdvisoriesClient SecurityAdvisories => new SecurityAdvisoriesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Owner or admin management of users interactions.
        /// </summary>
        public InteractionsClient Interactions => new InteractionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Interact with GitHub Classroom.
        /// </summary>
        public ClassroomClient Classroom => new ClassroomClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Desktop specific endpoints.
        /// </summary>
        public DesktopClient Desktop => new DesktopClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Endpoints to manage GitHub Enterprise Teams.
        /// </summary>
        public EnterpriseTeamsClient EnterpriseTeams => new EnterpriseTeamsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::Newtonsoft.Json.JsonSerializerSettings();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}