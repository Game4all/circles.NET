using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! beatmap returned by API
    /// </summary>
    public sealed class APIBeatmap
    {
        [JsonProperty(PropertyName = "beatmapset_id")]
        public string MapsetId { get; set; }

        [JsonProperty(PropertyName = "beatmap_id")]
        public string BeatmapId { get; set; }

        [JsonProperty(PropertyName = "approved")]
        public string ApprovedStatus { get; set; }

        [JsonProperty(PropertyName = "total_length")]
        public string TotalLength { get; set; }

        [JsonProperty(PropertyName = "hit_length")]
        public string HitLength { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "file_md5")]
        public string MD5 { get; set; }

        [JsonProperty(PropertyName = "diff_size")]
        public string CS { get; set; }

        [JsonProperty(PropertyName = "diff_overall")]
        public string OD { get; set; }

        [JsonProperty(PropertyName = "diff_approach")]
        public string AR { get; set; }

        [JsonProperty(PropertyName = "diff_drain")]
        public string HP { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Gamemode { get; set; }

        [JsonProperty(PropertyName = "approved_date")]
        public string ApprovedDate { get; set; }

        [JsonProperty(PropertyName = "last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        [JsonProperty(PropertyName = "bpm")]
        public string Bpm { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "genre_id")]
        public string Genre { get; set; }

        [JsonProperty(PropertyName = "language_id")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "favourite_count")]
        public string FavouriteCount { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public string Playcount { get; set; }

        [JsonProperty(PropertyName = "passcount")]
        public string Passcount { get; set; }

        [JsonProperty(PropertyName = "max_combo")]
        public string MaxCombo { get; set; }

        [JsonProperty(PropertyName = "difficultyrating")]
        public string StarRating { get; set; }
    }
}
