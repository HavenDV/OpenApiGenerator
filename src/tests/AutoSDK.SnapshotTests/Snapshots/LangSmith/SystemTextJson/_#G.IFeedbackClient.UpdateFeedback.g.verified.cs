﻿//HintName: G.IFeedbackClient.UpdateFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackSchema> UpdateFeedbackAsync(
            global::System.Guid feedbackId,
            global::G.FeedbackUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackSchema> UpdateFeedbackAsync(
            global::System.Guid feedbackId,
            global::G.AnyOf<double?, int?, bool?, object>? score = default,
            global::G.AnyOf<double?, int?, bool?, string, global::G.FeedbackUpdateSchemaValue, object>? value = default,
            global::G.AnyOf<string, object>? comment = default,
            global::G.AnyOf<global::G.FeedbackUpdateSchemaCorrection, string, object>? correction = default,
            global::G.AnyOf<global::G.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}