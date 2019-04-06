using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! user returned from API
    /// </summary>
    public sealed class APIUser
    {
        /// <summary>
        /// The UserID for this user
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; private set; }

        /// <summary>
        /// The username of this user
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; private set; }

        /// <summary>
        /// Total 300s hits
        /// </summary>
        [JsonProperty(PropertyName = "count300")]
        public long Count300 { get; private set; }

        /// <summary>
        /// Total 100s hits
        /// </summary>
        [JsonProperty(PropertyName = "count100")]
        public long Count100 { get; private set; }

        /// <summary>
        /// Total 50s hits
        /// </summary>
        [JsonProperty(PropertyName = "count50")]
        public long Count50 { get; private set; }

        /// <summary>
        /// Playcount
        /// </summary>
        [JsonProperty(PropertyName = "playcount")]
        public long Playcount { get; private set; }

        /// <summary>
        /// Total ranked score
        /// </summary>
        [JsonProperty(PropertyName = "ranked_score")]
        public long RankedScore { get; private set; }

        /// <summary>
        /// Total (unranked) score
        /// </summary>
        [JsonProperty(PropertyName = "total_score")]
        public long TotalScore { get; private set; }

        /// <summary>
        /// Player's Rank in global leaderboard
        /// </summary>
        [JsonProperty(PropertyName = "pp_rank")]
        public int PpRank { get; private set; }

        /// <summary>
        /// Level of this player
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public float Level { get; private set; }

        /// <summary>
        /// Raw PP of this player
        /// </summary>
        [JsonProperty(PropertyName = "pp_raw")]
        public float PpRaw { get; private set; }

        /// <summary>
        /// Accuracy of this player
        /// </summary>
        [JsonProperty(PropertyName = "accuracy")]
        public float Accuracy { get; private set; }

        /// <summary>
        /// Total number of SSes
        /// </summary>
        [JsonProperty(PropertyName = "count_rank_ss")]
        public long CountRankSS { get; private set; }

        /// <summary>
        /// Total number of Ses
        /// </summary>
        [JsonProperty(PropertyName = "count_rank_s")]
        public long CountRankS { get; private set; }

        /// <summary>
        /// Total number of As
        /// </summary>
        [JsonProperty(PropertyName = "count_rank_a")]
        public long CountRankA { get; private set; }

        /// <summary>
        /// Player's country code
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; private set; }

        /// <summary>
        /// Player's rank in his country leaderboard
        /// </summary>
        [JsonProperty(PropertyName = "pp_country_rank")]
        public int PpCountryRank { get; private set; }

        //public List<Event> events { get; set; }
    }
}