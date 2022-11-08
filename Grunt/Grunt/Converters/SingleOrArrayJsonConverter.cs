using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Converters
{
    internal class SingleOrArrayJsonConverter<T> : JsonConverter<List<T>>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(List<T>);
        }

        public override List<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                using (JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader))
                {
                    return jsonDoc.Deserialize<List<T>>();
                }
            }
            else
            {
                using (JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader))
                {
                    return new List<T> { jsonDoc.Deserialize<T>() };
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
