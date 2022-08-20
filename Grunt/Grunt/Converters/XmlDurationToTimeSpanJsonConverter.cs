// <copyright file="XmlDurationToTimeSpanJsonConverter.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace OpenSpartan.Grunt.Converters
{
    internal class XmlDurationToTimeSpanJsonConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            return string.IsNullOrWhiteSpace(value) ? TimeSpan.Zero : XmlConvert.ToTimeSpan(value);
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(XmlConvert.ToString(value));
        }
    }
}
