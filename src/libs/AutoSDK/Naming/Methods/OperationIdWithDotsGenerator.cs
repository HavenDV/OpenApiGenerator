using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class OperationIdWithDotsGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operation.Operation.OperationId is null ||
            !operation.Operation.OperationId.Contains('.'))
        {
            return null;
        }
        
        return string.Concat(operation.Operation.OperationId
            .Split('.')
            .Reverse()
            .Select(x => x.ToPropertyName()));
    }
}