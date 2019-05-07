using Newtonsoft.Json;
using System;

namespace circles.NET.Converters
{
    public class TimespanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => TimeSpan.FromSeconds(double.Parse((string)reader.Value));

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
