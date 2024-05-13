﻿//HintName: G.Models.CreateChatCompletionFunctionResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
    /// </summary>
    public abstract class CreateChatCompletionFunctionResponseChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Stop = "stop";
        /// <summary>
        /// 
        /// </summary>
        public const string Length = "length";
        /// <summary>
        /// 
        /// </summary>
        public const string FunctionCall = "function_call";
        /// <summary>
        /// 
        /// </summary>
        public const string ContentFilter = "content_filter";
    }
}