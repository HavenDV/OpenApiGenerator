﻿//HintName: G.Models.WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
    /// </summary>
    public abstract class WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRTITLE = "PR_TITLE";
        /// <summary>
        /// 
        /// </summary>
        public const string MERGEMESSAGE = "MERGE_MESSAGE";
    }
}