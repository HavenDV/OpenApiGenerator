﻿//HintName: G.ITrainingClient.TrainingGetTestExcerpts.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetTestExcerpts.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestExcerpt>> TrainingGetTestExcerptsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? testId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}