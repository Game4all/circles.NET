using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace circles.NET.Enums
{
    [Flags]
    public enum Mods
    {
        None = 0,
        [Description("NF")]
        NoFail = 1,
        [Description("EZ")]
        Easy = 2,
        [Description("TD")]
        TouchDevice = 4,
        [Description("HD")]
        Hidden = 8,
        [Description("HR")]
        HardRock = 16,
        [Description("SD")]
        SuddenDeath = 32,
        [Description("DT")]
        DoubleTime = 64,
        [Description("RX")]
        Relax = 128,
        [Description("HT")]
        HalfTime = 256,
        [Description("NC")]
        Nightcore = 512,
        [Description("FL")]
        Flashlight = 1024,
        [Description("AT")]
        Autoplay = 2048,
        [Description("SO")]
        SpunOut = 4096,
        [Description("RX2")]
        Relax2 = 8192,
        [Description("PF")]
        Perfect = 16384,
        [Description("4K")]
        Key4 = 32768,
        [Description("5K")]
        Key5 = 65536,
        [Description("6K")]
        Key6 = 131072,
        [Description("7K")]
        Key7 = 262144,
        [Description("8K")]
        Key8 = 524288,
        [Description("FI")]
        FadeIn = 1048576,
        [Description("RD")]
        Random = 2097152,
        [Description("CN")]
        Cinema = 4194304,
        [Description("TP")]
        Target = 8388608,
        [Description("9K")]
        Key9 = 16777216,
        [Description("CO")]
        KeyCoop = 33554432,
        [Description("1K")]
        Key1 = 67108864,
        [Description("3K")]
        Key3 = 134217728,
        [Description("2K")]
        Key2 = 268435456,
        [Description("ScoreV2")]
        ScoreV2 = 536870912,
        [Description("NF")]
        LastMod = 1073741824,
    }

    public static class ModsEnumExtensions
    {
        /// <summary>
        /// Gets a short string representation of the given <see cref="Mods"/> bitflag / value
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static string ToShortString(this Mods mod)
        {
            var sb = new StringBuilder();
            var mods = mod.GetFromBitflag();
            var type = typeof(Mods);

            foreach (var item in mods)
            {
                var memInfo = type.GetMember(item.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                sb.Append(((DescriptionAttribute)attributes[0]).Description);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets a short string representation of the given <see cref="IEnumerable{Mods}"/> of <see cref="Mods"/>
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static string ToShortString(this IEnumerable<Mods> mods)
        {
            var sb = new StringBuilder();
            foreach (var item in mods)
                sb.Append(item.ToShortString());
            return sb.ToString();
        }

        /// <summary>
        /// Converts a bitflag representation into an array of <see cref="Mods"/>
        /// </summary>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static Mods[] GetFromBitflag(this Mods flags) //adapted code from SO answer https://stackoverflow.com/questions/4171140/iterate-over-values-in-flags-enum
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

        /// <summary>
        /// Converts an <see cref="IEnumerable{Mods}"/> to a <see cref="Mods"/> bitflag representation
        /// </summary>
        /// <param name="mods"></param>
        /// <returns></returns>
        public static Mods ToBitflag(this IEnumerable<Mods> mods)
        {
            var value = Mods.None;
            foreach (var item in mods)
                value |= item;
            return value;
        }
    }
}