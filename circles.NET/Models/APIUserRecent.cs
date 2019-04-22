using circles.NET.Converters;
using circles.NET.Enums;
using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! score from a play done recently returned by API
    /// </summary>
    public sealed class APIUserRecent : APIModel
    {
        /// <summary>
        /// The ID of the beatmap (not beatmapSet) this score was achieved on
        /// </summary>
        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; private set; }

        /// <summary>
        /// Total score awarded on this map
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public long Score { get; private set; }

        /// <summary>
        /// Max combo achieved in this score
        /// </summary>
        [JsonProperty(PropertyName = "maxcombo")]
        public int MaxCombo { get; private set; }

        /// <summary>
        /// Number of 50s hits
        /// </summary>
        [JsonProperty(PropertyName = "count50")]
        public int Count50s { get; private set; }

        /// <summary>
        /// Number of 100s hits
        /// </summary>
        [JsonProperty(PropertyName = "count100")]
        public int Count100s { get; private set; }

        /// <summary>
        /// Number of 300s hits
        /// </summary>
        [JsonProperty(PropertyName = "count300")]
        public int Count300s { get; private set; }

        /// <summary>
        /// Number of missed hits
        /// </summary>
        [JsonProperty(PropertyName = "countmiss")]
        public int CountMisses { get; private set; }

        /// <summary>
        /// Number of katus hits
        /// </summary>
        [JsonProperty(PropertyName = "countkatu")]
        public int CountKatu { get; private set; }

        /// <summary>
        /// Number of gekis hits
        /// </summary>
        [JsonProperty(PropertyName = "countgeki")]
        public int CountGeki { get; private set; }

        /// <summary>
        /// A bool indicating whether this score is a perfect
        /// </summary>
        [JsonProperty(PropertyName = "perfect")]
        [JsonConverter(typeof(StringBoolConverter))]
        public bool Perfect { get; private set; }

        /// <summary>
        /// Mods enabled for this score
        /// </summary>
        [JsonProperty(PropertyName = "enabled_mods")]
        [JsonConverter(typeof(ModsJSONConverter))]
        public Mods[] Mods { get; private set; }

        /// <summary>
        /// The UserID of the player who achieved this score
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// The date on which this score was achieved
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; private set; }

        /// <summary>
        /// The grade achieved on this score (can be F if player didn't completed the whole map)
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; private set; }

        /// <summary>
        /// The pp awarded for this score
        /// </summary>
        [JsonProperty(PropertyName = "pp")]
        public float Pp { get; private set; }

        /// <summary>
        /// The accuracy for this score
        /// </summary>
        [JsonProperty(PropertyName = "accuracy")]
        public float Accuracy { get; private set; }
    }
}