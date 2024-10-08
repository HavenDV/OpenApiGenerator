﻿//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentCreatedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentCreatedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentCreatedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentCreatedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentCreatedWorkflowRunStatus.Waiting => "waiting",
                WebhookDeploymentCreatedWorkflowRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookDeploymentCreatedWorkflowRunStatus.Requested,
                "in_progress" => WebhookDeploymentCreatedWorkflowRunStatus.InProgress,
                "completed" => WebhookDeploymentCreatedWorkflowRunStatus.Completed,
                "queued" => WebhookDeploymentCreatedWorkflowRunStatus.Queued,
                "waiting" => WebhookDeploymentCreatedWorkflowRunStatus.Waiting,
                "pending" => WebhookDeploymentCreatedWorkflowRunStatus.Pending,
                _ => null,
            };
        }
    }
}