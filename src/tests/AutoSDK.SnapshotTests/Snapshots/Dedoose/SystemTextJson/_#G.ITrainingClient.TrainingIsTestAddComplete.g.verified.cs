﻿//HintName: G.ITrainingClient.TrainingIsTestAddComplete.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// IsTestAddComplete.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="addTestWorkerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> TrainingIsTestAddCompleteAsync(
            string? token = default,
            string? addTestWorkerId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}