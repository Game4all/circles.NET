using Newtonsoft.Json;
using System;

namespace circles.NET.Converters
{
    class StringBoolConverter : JsonConverter
    {
        public StringBoolConverter()
        {
        }

        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool.TryParse((string)reader.Value, out var bools);
            return bools;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
