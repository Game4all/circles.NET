using circles.NET.Enums;
using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! score returned from API
    /// </summary>
    public sealed class APIScore
    {
        [JsonProperty(PropertyName = "score_id")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "score")]
        public long Score { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "maxcombo")]
        public int MaxCombo { get; set; }

        [JsonProperty(PropertyName = "count50")]
        public int Count50s { get; set; }

        [JsonProperty(PropertyName = "count100")]
        public int Count100s { get; set; }

        [JsonProperty(PropertyName = "count300")]
        public int Count300s { get; set; }

        [JsonProperty(PropertyName = "countmiss")]
        public int CountMisses { get; set; }

        [JsonProperty(PropertyName = "countkatu")]
        public int CountKatu { get; set; }

        [JsonProperty(PropertyName = "countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty(PropertyName = "perfect")]
        public string Perfect { get; set; }

        [JsonProperty(PropertyName = "enabled_mods")]
        [JsonConverter(typeof(ModsJSONDeserializer))]
        public Mods[] Mods { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "pp")]
        public float Pp { get; set; }
    }
}