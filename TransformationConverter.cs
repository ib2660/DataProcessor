using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DataProcessor.Transformations;

namespace DataProcessor
{
    internal class TransformationConverter : JsonConverter<ITransformation>
    {
        public override ITransformation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var type = root.GetProperty("Type").GetString();

                return type switch
                {
                    "ListTransformation" => new ListTransformation(),
                    "MaxTransformation" => new MaxTransformation(),
                    "MinOfTransformations" => new MinOfTransformations(),
                    _ => throw new NotSupportedException($"Transformation type '{type}' is not supported")
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, ITransformation value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Type", value.GetType().Name);
            writer.WriteEndObject();
        }
    }
}
