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
            return GetUniqueFlags((Mods)encodedFlags);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        //adapted code from SO answer https://stackoverflow.com/questions/4171140/iterate-over-values-in-flags-enum
        private Mods[] GetUniqueFlags(Mods flags)
        {
            ulong flag = 1;
            var mods = new List<Mods>();
            foreach (var value in Enum.GetValues(flags.GetType()).Cast<Mods>())
            {
                ulong bits = Convert.ToUInt64(value);
                while (flag < bits)
                {
                    flag <<= 1;
                }

                if (flag == bits && flags.HasFlag(value))
                {
                    mods.Add(value);
                }
            }

            if (mods.Contains(Mods.DoubleTime) && mods.Contains(Mods.Nightcore)) //if DTNC is parsed, only return NC
            {
                mods.RemoveAll((s) => s == Mods.DoubleTime || s == Mods.Nightcore);
                mods.Add(Mods.Nightcore);
            }

            return mods.ToArray();
        }
    }
}