using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! user returned from API
    /// </summary>
    public sealed class APIUser
    {
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "count300")]
        public string Count300 { get; set; }

        [JsonProperty(PropertyName = "count100")]
        public string Count100 { get; set; }

        [JsonProperty(PropertyName = "count50")]
        public string Count50 { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public string Playcount { get; set; }

        [JsonProperty(PropertyName = "ranked_score")]
        public string RankedScore { get; set; }

        [JsonProperty(PropertyName = "total_score")]
        public string TotalScore { get; set; }

        [JsonProperty(PropertyName = "pp_rank")]
        public string PpRank { get; set; }

        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        [JsonProperty(PropertyName = "pp_raw")]
        public string PpRaw { get; set; }

        [JsonProperty(PropertyName = "accuracy")]
        public string Accuracy { get; set; }

        [JsonProperty(PropertyName = "count_rank_ss")]
        public string CountRankSS { get; set; }

        [JsonProperty(PropertyName = "count_rank_s")]
        public string CountRankS { get; set; }

        [JsonProperty(PropertyName = "count_rank_a")]
        public string CountRankA { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "pp_country_rank")]
        public string PpCountryRank { get; set; }

        //public List<Event> events { get; set; }
    }
}