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
        [JsonProperty(PropertyName = "beatmapset_id")]
        public long MapsetId { get; set; }

        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; set; }

        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(ApprovedStatusConverter))]
        public ApprovedStatus ApprovedStatus { get; set; }

        [JsonProperty(PropertyName = "total_length")]
        public int TotalLength { get; set; }

        [JsonProperty(PropertyName = "hit_length")]
        public int HitLength { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "file_md5")]
        public string MD5 { get; set; }

        [JsonProperty(PropertyName = "diff_size")]
        public float CS { get; set; }

        [JsonProperty(PropertyName = "diff_overall")]
        public float OD { get; set; }

        [JsonProperty(PropertyName = "diff_approach")]
        public float AR { get; set; }

        [JsonProperty(PropertyName = "diff_drain")]
        public float HP { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public Gamemode Gamemode { get; set; }

        [JsonProperty(PropertyName = "approved_date")]
        public DateTime? ApprovedDate { get; set; }

        [JsonProperty(PropertyName = "last_update")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        [JsonProperty(PropertyName = "bpm")]
        public float Bpm { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "genre_id")]
        public string Genre { get; set; }

        [JsonProperty(PropertyName = "language_id")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "favourite_count")]
        public int FavouriteCount { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public int Playcount { get; set; }

        [JsonProperty(PropertyName = "passcount")]
        public int Passcount { get; set; }

        [JsonProperty(PropertyName = "max_combo")]
        public int? MaxCombo { get; set; }

        [JsonProperty(PropertyName = "difficultyrating")]
        public float StarRating { get; set; }
    }
}