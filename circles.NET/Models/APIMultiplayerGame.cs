using circles.NET.Converters;
using circles.NET.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! ongoing or finished multiplayer game returned by API
    /// </summary>
    public sealed class APIMultiplayerGame
    {
        [JsonProperty(PropertyName = "game_id")]
        public long GameId { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }

        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; set; }

        [JsonProperty(PropertyName = "play_mode")]
        public Gamemode Gamemode { get; set; }

        [JsonProperty(PropertyName = "match_type")]
        public string MatchType { get; set; }

        [JsonProperty(PropertyName = "scoring_type")]
        public string ScoringType { get; set; }

        [JsonProperty(PropertyName = "team_type")]
        public string TeamType { get; set; }

        [JsonProperty(PropertyName = "mods")]
        [JsonConverter(typeof(ModsJSONConverter))]
        public Mods[] Mods { get; set; }

        [JsonProperty(PropertyName = "scores")]
        public List<APIScore> Scores { get; set; }
    }
}