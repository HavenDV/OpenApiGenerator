using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextConverters(
        EndPoint endPoint)
    {
        if (!endPoint.GenerateJsonSerializerContextTypes ||
            endPoint.JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    internal sealed partial class JsonSerializerContextConverters
    {{
        private readonly global::System.Type[] _types = new[]
        {{
{endPoint.Converters.Select(x => $@" 
            typeof({x}),
").Inject()}
        }};
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}