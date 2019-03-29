using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! user returned from API
    /// </summary>
    public sealed class APIUser
    {
        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "count300")]
        public long Count300 { get; set; }

        [JsonProperty(PropertyName = "count100")]
        public long Count100 { get; set; }

        [JsonProperty(PropertyName = "count50")]
        public long Count50 { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public long Playcount { get; set; }

        [JsonProperty(PropertyName = "ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty(PropertyName = "total_score")]
        public long TotalScore { get; set; }

        [JsonProperty(PropertyName = "pp_rank")]
        public int PpRank { get; set; }

        [JsonProperty(PropertyName = "level")]
        public float Level { get; set; }

        [JsonProperty(PropertyName = "pp_raw")]
        public float PpRaw { get; set; }

        [JsonProperty(PropertyName = "accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty(PropertyName = "count_rank_ss")]
        public long CountRankSS { get; set; }

        [JsonProperty(PropertyName = "count_rank_s")]
        public long CountRankS { get; set; }

        [JsonProperty(PropertyName = "count_rank_a")]
        public long CountRankA { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "pp_country_rank")]
        public int PpCountryRank { get; set; }

        //public List<Event> events { get; set; }
    }
}