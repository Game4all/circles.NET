using circles.NET.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace circles.NET.Converters
{
    public class ModsJSONConverter : JsonConverter
    {
        public ModsJSONConverter()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(Mods[]))
                return true;
            else
                return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var encodedFlags = int.Parse((string)reader.Value);
            return ((Mods)encodedFlags).GetFromBitflag();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}