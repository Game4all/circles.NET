using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    public sealed class APIMultiplayerRoomInfo
    {
        [JsonProperty(PropertyName = "match_id")]
        public long MatchId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
    }
}