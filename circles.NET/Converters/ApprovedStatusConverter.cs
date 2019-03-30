using circles.NET.Enums;
using Newtonsoft.Json;
using System;

namespace circles.NET.Converters
{
    public class ApprovedStatusConverter : JsonConverter
    {
        public ApprovedStatusConverter()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => (ApprovedStatus)int.Parse((string)reader.Value);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}