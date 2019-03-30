using circles.NET.Converters;
using circles.NET.Enums;
using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! beatmap returned by API
    /// </summary>
    public sealed class APIBeatmap
    {
        /// <summary>
        /// The ID of the mapset this beatmap belongs to
        /// </summary>
        [JsonProperty(PropertyName = "beatmapset_id")]
        public long MapsetId { get; set; }

        /// <summary>
        /// The ID of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; set; }

        /// <summary>
        /// The <see cref="ApprovedStatus"/> of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(ApprovedStatusConverter))]
        public ApprovedStatus ApprovedStatus { get; set; }

        /// <summary>
        /// The total length (in seconds) of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "total_length")]
        public int TotalLength { get; set; }

        /// <summary>
        /// The playable length (in seconds) of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "hit_length")]
        public int PlaybableLength { get; set; }

        /// <summary>
        /// The name of this beatmap's difficulty
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Difficulty { get; set; }

        /// <summary>
        /// The MD5 hash of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "file_md5")]
        public string MD5 { get; set; }

        /// <summary>
        /// Circle Size
        /// </summary>
        [JsonProperty(PropertyName = "diff_size")]
        public float CS { get; set; }

        /// <summary>
        /// Overall Difficulty
        /// </summary>
        [JsonProperty(PropertyName = "diff_overall")]
        public float OD { get; set; }

        /// <summary>
        /// Approach Rate
        /// </summary>
        [JsonProperty(PropertyName = "diff_approach")]
        public float AR { get; set; }

        /// <summary>
        /// HP Drain
        /// </summary>
        [JsonProperty(PropertyName = "diff_drain")]
        public float HP { get; set; }

        /// <summary>
        /// The gamemode of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public Gamemode Gamemode { get; set; }

        /// <summary>
        /// The date this beatmap was approved
        /// </summary>
        [JsonProperty(PropertyName = "approved_date")]
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// The date this beatmap was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Compositor of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; set; }

        /// <summary>
        /// Title name of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Creator of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// BPM of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "bpm")]
        public float Bpm { get; set; }

        /// <summary>
        /// Source of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Tags of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Genre of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "genre_id")]
        public string Genre { get; set; }

        /// <summary>
        /// Language of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "language_id")]
        public string Language { get; set; }

        /// <summary>
        /// Number of times this beatmap has been favourited
        /// </summary>
        [JsonProperty(PropertyName = "favourite_count")]
        public int FavouriteCount { get; set; }

        /// <summary>
        /// Number of times this beamap has been played
        /// </summary>
        [JsonProperty(PropertyName = "playcount")]
        public int Playcount { get; set; }

        /// <summary>
        /// Number of times people passed this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "passcount")]
        public int Passcount { get; set; }

        /// <summary>
        /// The max achievable combo on this map
        /// </summary>
        [JsonProperty(PropertyName = "max_combo")]
        public int? MaxCombo { get; set; }

        /// <summary>
        /// The star rating of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "difficultyrating")]
        public float StarRating { get; set; }
    }
}