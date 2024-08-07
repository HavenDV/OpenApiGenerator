﻿//HintName: JsonConverters.OneOf2.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2> : global::System.Text.Json.Serialization.JsonConverter<global::System.OneOf<T1, T2>>
    {
        /// <inheritdoc />
        public override global::System.OneOf<T1, T2> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::System.OneOf<T1, T2>(
                value1,

                value2
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(T1).Name}, {typeof(T2).Name}>");
            }

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.OneOf<T1, T2> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(T1).Name}, {typeof(T2).Name}> object.");
            }

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }

            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}