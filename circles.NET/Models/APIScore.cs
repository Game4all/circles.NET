using circles.NET.Converters;
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
        /// <summary>
        /// The ID of this score
        /// </summary>
        [JsonProperty(PropertyName = "score_id")]
        public long ID { get; set; }

        /// <summary>
        /// Total score awarded on this map
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public long Score { get; set; }

        /// <summary>
        /// Username of the played who achieved the score
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Max combo achieved in this score
        /// </summary>
        [JsonProperty(PropertyName = "maxcombo")]
        public int MaxCombo { get; set; }

        /// <summary>
        /// Number of 50s hits
        /// </summary>
        [JsonProperty(PropertyName = "count50")]
        public int Count50s { get; set; }

        /// <summary>
        /// Number of 100s hits
        /// </summary>
        [JsonProperty(PropertyName = "count100")]
        public int Count100s { get; set; }

        /// <summary>
        /// Number of 300s hits
        /// </summary>
        [JsonProperty(PropertyName = "count300")]
        public int Count300s { get; set; }

        /// <summary>
        /// Number of missed hits
        /// </summary>
        [JsonProperty(PropertyName = "countmiss")]
        public int CountMisses { get; set; }

        /// <summary>
        /// Number of katus hits
        /// </summary>
        [JsonProperty(PropertyName = "countkatu")]
        public int CountKatu { get; set; }

        /// <summary>
        /// Number of gekis hits
        /// </summary>
        [JsonProperty(PropertyName = "countgeki")]
        public int CountGeki { get; set; }

        /// <summary>
        /// A bool indicating whether this score is a perfect
        /// </summary>
        [JsonProperty(PropertyName = "perfect")]
        [JsonConverter(typeof(StringBoolConverter))]
        public bool Perfect { get; set; }

        /// <summary>
        /// Mods enabled for this score
        /// </summary>
        [JsonProperty(PropertyName = "enabled_mods")]
        [JsonConverter(typeof(ModsJSONConverter))]
        public Mods[] Mods { get; set; }

        /// <summary>
        /// The UserID of the player who achieved this score
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// The date on which this score was achieved
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The grade achieved on this score
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        /// <summary>
        /// The pp awarded for this score
        /// </summary>
        [JsonProperty(PropertyName = "pp")]
        public float Pp { get; set; }
    }
}