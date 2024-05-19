namespace OpenApiGenerator.Core.Json;

public class SystemTextJsonSerializer : IJsonSerializer
{
    public static IJsonSerializer Instance { get; } = new SystemTextJsonSerializer();
    
    public string GeneratePropertyAttribute(string id, bool isRequired)
    {
        return $"[global::System.Text.Json.Serialization.JsonPropertyName(\"{id}\")]";
    }

    public string GenerateExtensionDataAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonExtensionData]";
    }
    
    public string GenerateRequiredAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonRequired]";
    }
    
    public string GenerateSerializeCall(string type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? "global::System.Text.Json.JsonSerializer.Serialize(request)"
            : $"global::System.Text.Json.JsonSerializer.Serialize(request, global::{jsonSerializerContext}.Default.{type})";
    }
    
    public string GenerateDeserializeCall(string type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"global::System.Text.Json.JsonSerializer.Deserialize<{type}>(content)"
            : $"global::System.Text.Json.JsonSerializer.Deserialize(content, global::{jsonSerializerContext}.Default.{type})";
    }
}