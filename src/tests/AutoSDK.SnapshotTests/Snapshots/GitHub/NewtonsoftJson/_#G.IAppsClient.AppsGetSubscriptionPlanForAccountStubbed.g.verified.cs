﻿//HintName: G.IAppsClient.AppsGetSubscriptionPlanForAccountStubbed.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get a subscription plan for an account (stubbed)<br/>
        /// Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.<br/>
        /// GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MarketplacePurchase> AppsGetSubscriptionPlanForAccountStubbedAsync(
            int accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}