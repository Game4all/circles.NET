using System;
using System.ComponentModel;
using System.Reflection;

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
        [Description("FadeIn")]
        FadeIn = 1048576,
        [Description("RN")]
        Random = 2097152,
        [Description("CN")]
        Cinema = 4194304,
        [Description("TP")]
        Target = 8388608,
        [Description("9K")]
        Key9 = 16777216,
        [Description("CP")]
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
        /// Gets a short string representation of the given gamemode
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static string ToShortString(this Mods mod) => mod.GetType().GetProperty(mod.ToString()).GetCustomAttribute<DescriptionAttribute>().Description.ToString().ToUpper();
    }
}