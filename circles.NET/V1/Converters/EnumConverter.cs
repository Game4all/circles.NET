using Newtonsoft.Json;
using System;

namespace circles.NET.V1.Converters
{
    internal class EnumConverter<T> : JsonConverter
        where T : Enum
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(T);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var val = int.Parse((string)reader.Value);
            var enumVal = Enum.ToObject(typeof(T), val);
            return enumVal;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}