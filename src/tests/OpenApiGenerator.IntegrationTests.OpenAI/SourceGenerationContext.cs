using System.Text.Json.Serialization;

namespace OpenApiGenerator.IntegrationTests;

[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    WriteIndented = true,
    Converters = [
        typeof(JsonConverters.ListModelsResponseObjectJsonConverter),
        typeof(JsonConverters.ListModelsResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateCompletionRequestModelJsonConverter),
        typeof(JsonConverters.CreateCompletionRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateCompletionResponseChoicesFinishReasonJsonConverter),
        typeof(JsonConverters.CreateCompletionResponseChoicesFinishReasonNullableJsonConverter),
        typeof(JsonConverters.CreateCompletionResponseObjectJsonConverter),
        typeof(JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionToolTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionToolTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionToolChoiceOptionVariant1JsonConverter),
        typeof(JsonConverters.ChatCompletionToolChoiceOptionVariant1NullableJsonConverter),
        typeof(JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),
        typeof(JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),
        typeof(JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),
        typeof(JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestResponseFormatTypeJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestResponseFormatTypeNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestModelJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),
        typeof(JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionResponseChoicesFinishReasonJsonConverter),
        typeof(JsonConverters.CreateChatCompletionResponseChoicesFinishReasonNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionResponseObjectJsonConverter),
        typeof(JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionFunctionResponseChoicesFinishReasonJsonConverter),
        typeof(JsonConverters.CreateChatCompletionFunctionResponseChoicesFinishReasonNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter),
        typeof(JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter),
        typeof(JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),
        typeof(JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionStreamResponseChoicesFinishReasonJsonConverter),
        typeof(JsonConverters.CreateChatCompletionStreamResponseChoicesFinishReasonNullableJsonConverter),
        typeof(JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),
        typeof(JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateImageRequestQualityJsonConverter),
        typeof(JsonConverters.CreateImageRequestQualityNullableJsonConverter),
        typeof(JsonConverters.CreateImageRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateImageRequestSizeJsonConverter),
        typeof(JsonConverters.CreateImageRequestSizeNullableJsonConverter),
        typeof(JsonConverters.CreateImageRequestStyleJsonConverter),
        typeof(JsonConverters.CreateImageRequestStyleNullableJsonConverter),
        typeof(JsonConverters.CreateImageRequestModelJsonConverter),
        typeof(JsonConverters.CreateImageRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestSizeJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestModelJsonConverter),
        typeof(JsonConverters.CreateImageEditRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestSizeJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestModelJsonConverter),
        typeof(JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateModerationRequestModelJsonConverter),
        typeof(JsonConverters.CreateModerationRequestModelNullableJsonConverter),
        typeof(JsonConverters.ListFilesResponseObjectJsonConverter),
        typeof(JsonConverters.ListFilesResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateFileRequestPurposeJsonConverter),
        typeof(JsonConverters.CreateFileRequestPurposeNullableJsonConverter),
        typeof(JsonConverters.DeleteFileResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteFileResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestIntegrationsTypeJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestIntegrationsTypeNullableJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestModelJsonConverter),
        typeof(JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter),
        typeof(JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),
        typeof(JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),
        typeof(JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),
        typeof(JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),
        typeof(JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),
        typeof(JsonConverters.CreateEmbeddingRequestModelJsonConverter),
        typeof(JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateEmbeddingResponseObjectJsonConverter),
        typeof(JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestTimestampGranularitiesJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestTimestampGranularitiesNullableJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestModelJsonConverter),
        typeof(JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateTranslationRequestModelJsonConverter),
        typeof(JsonConverters.CreateTranslationRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestVoiceJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestModelJsonConverter),
        typeof(JsonConverters.CreateSpeechRequestModelNullableJsonConverter),
        typeof(JsonConverters.ModelObjectJsonConverter),
        typeof(JsonConverters.ModelObjectNullableJsonConverter),
        typeof(JsonConverters.OpenAIFileObjectJsonConverter),
        typeof(JsonConverters.OpenAIFileObjectNullableJsonConverter),
        typeof(JsonConverters.OpenAIFilePurposeJsonConverter),
        typeof(JsonConverters.OpenAIFilePurposeNullableJsonConverter),
        typeof(JsonConverters.OpenAIFileStatusJsonConverter),
        typeof(JsonConverters.OpenAIFileStatusNullableJsonConverter),
        typeof(JsonConverters.EmbeddingObjectJsonConverter),
        typeof(JsonConverters.EmbeddingObjectNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),
        typeof(JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobObjectJsonConverter),
        typeof(JsonConverters.FineTuningJobObjectNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobStatusJsonConverter),
        typeof(JsonConverters.FineTuningJobStatusNullableJsonConverter),
        typeof(JsonConverters.FineTuningIntegrationTypeJsonConverter),
        typeof(JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobEventLevelJsonConverter),
        typeof(JsonConverters.FineTuningJobEventLevelNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobEventObjectJsonConverter),
        typeof(JsonConverters.FineTuningJobEventObjectNullableJsonConverter),
        typeof(JsonConverters.FineTuningJobCheckpointObjectJsonConverter),
        typeof(JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),
        typeof(JsonConverters.AssistantsApiResponseFormatOptionVariant1JsonConverter),
        typeof(JsonConverters.AssistantsApiResponseFormatOptionVariant1NullableJsonConverter),
        typeof(JsonConverters.AssistantsApiResponseFormatTypeJsonConverter),
        typeof(JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter),
        typeof(JsonConverters.AssistantObjectObjectJsonConverter),
        typeof(JsonConverters.AssistantObjectObjectNullableJsonConverter),
        typeof(JsonConverters.AssistantObjectResponseFormatJsonConverter),
        typeof(JsonConverters.AssistantObjectResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeNullableJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestModelJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateAssistantRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.ModifyAssistantRequestResponseFormatJsonConverter),
        typeof(JsonConverters.ModifyAssistantRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.DeleteAssistantResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),
        typeof(JsonConverters.AssistantToolsCodeTypeJsonConverter),
        typeof(JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),
        typeof(JsonConverters.AssistantToolsFileSearchTypeJsonConverter),
        typeof(JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),
        typeof(JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),
        typeof(JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),
        typeof(JsonConverters.AssistantToolsFunctionTypeJsonConverter),
        typeof(JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),
        typeof(JsonConverters.TruncationObjectTypeJsonConverter),
        typeof(JsonConverters.TruncationObjectTypeNullableJsonConverter),
        typeof(JsonConverters.AssistantsApiToolChoiceOptionVariant1JsonConverter),
        typeof(JsonConverters.AssistantsApiToolChoiceOptionVariant1NullableJsonConverter),
        typeof(JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),
        typeof(JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),
        typeof(JsonConverters.RunObjectRequiredActionTypeJsonConverter),
        typeof(JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),
        typeof(JsonConverters.RunObjectLastErrorCodeJsonConverter),
        typeof(JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),
        typeof(JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),
        typeof(JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),
        typeof(JsonConverters.RunObjectObjectJsonConverter),
        typeof(JsonConverters.RunObjectObjectNullableJsonConverter),
        typeof(JsonConverters.RunObjectStatusJsonConverter),
        typeof(JsonConverters.RunObjectStatusNullableJsonConverter),
        typeof(JsonConverters.RunObjectToolChoiceJsonConverter),
        typeof(JsonConverters.RunObjectToolChoiceNullableJsonConverter),
        typeof(JsonConverters.RunObjectResponseFormatJsonConverter),
        typeof(JsonConverters.RunObjectResponseFormatNullableJsonConverter),
        typeof(JsonConverters.CreateRunRequestModelJsonConverter),
        typeof(JsonConverters.CreateRunRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateRunRequestToolChoiceJsonConverter),
        typeof(JsonConverters.CreateRunRequestToolChoiceNullableJsonConverter),
        typeof(JsonConverters.CreateRunRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateRunRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.RunToolCallObjectTypeJsonConverter),
        typeof(JsonConverters.RunToolCallObjectTypeNullableJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestModelJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestToolChoiceJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestToolChoiceNullableJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestResponseFormatJsonConverter),
        typeof(JsonConverters.CreateThreadAndRunRequestResponseFormatNullableJsonConverter),
        typeof(JsonConverters.ThreadObjectObjectJsonConverter),
        typeof(JsonConverters.ThreadObjectObjectNullableJsonConverter),
        typeof(JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeJsonConverter),
        typeof(JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeNullableJsonConverter),
        typeof(JsonConverters.DeleteThreadResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),
        typeof(JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),
        typeof(JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),
        typeof(JsonConverters.MessageObjectObjectJsonConverter),
        typeof(JsonConverters.MessageObjectObjectNullableJsonConverter),
        typeof(JsonConverters.MessageObjectStatusJsonConverter),
        typeof(JsonConverters.MessageObjectStatusNullableJsonConverter),
        typeof(JsonConverters.MessageObjectRoleJsonConverter),
        typeof(JsonConverters.MessageObjectRoleNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),
        typeof(JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaObjectObjectJsonConverter),
        typeof(JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),
        typeof(JsonConverters.CreateMessageRequestRoleJsonConverter),
        typeof(JsonConverters.CreateMessageRequestRoleNullableJsonConverter),
        typeof(JsonConverters.DeleteMessageResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),
        typeof(JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),
        typeof(JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),
        typeof(JsonConverters.MessageContentImageFileObjectTypeJsonConverter),
        typeof(JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),
        typeof(JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),
        typeof(JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),
        typeof(JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),
        typeof(JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageContentTextObjectTypeJsonConverter),
        typeof(JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),
        typeof(JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),
        typeof(JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),
        typeof(JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),
        typeof(JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepObjectLastErrorCodeJsonConverter),
        typeof(JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),
        typeof(JsonConverters.RunStepObjectObjectJsonConverter),
        typeof(JsonConverters.RunStepObjectObjectNullableJsonConverter),
        typeof(JsonConverters.RunStepObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepObjectStatusJsonConverter),
        typeof(JsonConverters.RunStepObjectStatusNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaObjectObjectJsonConverter),
        typeof(JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),
        typeof(JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),
        typeof(JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),
        typeof(JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),
        typeof(JsonConverters.VectorStoreObjectObjectJsonConverter),
        typeof(JsonConverters.VectorStoreObjectObjectNullableJsonConverter),
        typeof(JsonConverters.VectorStoreObjectStatusJsonConverter),
        typeof(JsonConverters.VectorStoreObjectStatusNullableJsonConverter),
        typeof(JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectObjectJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectStatusJsonConverter),
        typeof(JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),
        typeof(JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),
        typeof(JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),
        typeof(JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),
        typeof(JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),
        typeof(JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),
        typeof(JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),
        typeof(JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),
        typeof(JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),
        typeof(JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),
        typeof(JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),
        typeof(JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),
        typeof(JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),
        typeof(JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),
        typeof(JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),
        typeof(JsonConverters.ThreadStreamEventVariant1EventJsonConverter),
        typeof(JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant1EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant2EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant3EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant4EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant5EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant6EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant7EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant8EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant9EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant10EventJsonConverter),
        typeof(JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant1EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant2EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant3EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant4EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant5EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant6EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant7EventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant1EventJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant2EventJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant3EventJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant4EventJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant5EventJsonConverter),
        typeof(JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),
        typeof(JsonConverters.ErrorEventEventJsonConverter),
        typeof(JsonConverters.ErrorEventEventNullableJsonConverter),
        typeof(JsonConverters.DoneEventEventJsonConverter),
        typeof(JsonConverters.DoneEventEventNullableJsonConverter),
        typeof(JsonConverters.DoneEventDataJsonConverter),
        typeof(JsonConverters.DoneEventDataNullableJsonConverter),
        typeof(JsonConverters.BatchObjectJsonConverter),
        typeof(JsonConverters.BatchObjectNullableJsonConverter),
        typeof(JsonConverters.BatchStatusJsonConverter),
        typeof(JsonConverters.BatchStatusNullableJsonConverter),
        typeof(JsonConverters.BatchRequestInputMethodJsonConverter),
        typeof(JsonConverters.BatchRequestInputMethodNullableJsonConverter),
        typeof(JsonConverters.ListBatchesResponseObjectJsonConverter),
        typeof(JsonConverters.ListBatchesResponseObjectNullableJsonConverter),
        typeof(JsonConverters.ListAssistantsOrderJsonConverter),
        typeof(JsonConverters.ListAssistantsOrderNullableJsonConverter),
        typeof(JsonConverters.ListMessagesOrderJsonConverter),
        typeof(JsonConverters.ListMessagesOrderNullableJsonConverter),
        typeof(JsonConverters.ListRunsOrderJsonConverter),
        typeof(JsonConverters.ListRunsOrderNullableJsonConverter),
        typeof(JsonConverters.ListRunStepsOrderJsonConverter),
        typeof(JsonConverters.ListRunStepsOrderNullableJsonConverter),
        typeof(JsonConverters.ListVectorStoresOrderJsonConverter),
        typeof(JsonConverters.ListVectorStoresOrderNullableJsonConverter),
        typeof(JsonConverters.ListVectorStoreFilesOrderJsonConverter),
        typeof(JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),
        typeof(JsonConverters.ListVectorStoreFilesFilterJsonConverter),
        typeof(JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),
        typeof(JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),
        typeof(JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),
        typeof(JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),
        typeof(JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),
        typeof(JsonConverters.CreateBatchRequestEndpointJsonConverter),
        typeof(JsonConverters.CreateBatchRequestEndpointNullableJsonConverter),
        typeof(JsonConverters.CreateBatchRequestCompletionWindowJsonConverter),
        typeof(JsonConverters.CreateBatchRequestCompletionWindowNullableJsonConverter),
        typeof(JsonConverters.AnyOfJsonConverterFactory2),
        typeof(JsonConverters.AnyOfJsonConverterFactory1),
        typeof(JsonConverters.OneOfJsonConverterFactory4),
        typeof(JsonConverters.OneOfJsonConverterFactory2),
        typeof(JsonConverters.OneOfJsonConverterFactory1),
        typeof(JsonConverters.OneOfJsonConverterFactory5),
        typeof(JsonConverters.OneOfJsonConverterFactory3),
        typeof(JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageJsonConverter),
        typeof(JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),
        typeof(JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),
        typeof(JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),
        typeof(JsonConverters.ChunkingStrategyRequestParamJsonConverter),
        typeof(JsonConverters.AssistantStreamEventJsonConverter),
        typeof(JsonConverters.ThreadStreamEventJsonConverter),
        typeof(JsonConverters.RunStreamEventJsonConverter),
        typeof(JsonConverters.RunStepStreamEventJsonConverter),
        typeof(JsonConverters.MessageStreamEventJsonConverter),
        typeof(JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter),
    ])]
[JsonSerializable(typeof(JsonSerializerContextTypes))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;