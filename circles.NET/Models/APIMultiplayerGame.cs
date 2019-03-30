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
        /// <summary>
        /// The ID of this game
        /// </summary>
        [JsonProperty(PropertyName = "game_id")]
        public long GameId { get; set; }

        /// <summary>
        /// The time at which this game began
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time at which this game ended (can be null if it's ongoing)
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The ID of the beatmap (NOT BeatmapSet) currently played
        /// </summary>
        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; set; }

        /// <summary>
        /// The gamemode in which this beatmap is played in
        /// </summary>
        [JsonProperty(PropertyName = "play_mode")]
        public Gamemode Gamemode { get; set; }

        [JsonProperty(PropertyName = "match_type")]
        public string MatchType { get; set; }

        [JsonProperty(PropertyName = "scoring_type")]
        public string ScoringType { get; set; }

        [JsonProperty(PropertyName = "team_type")]
        public string TeamType { get; set; }

        /// <summary>
        /// Mods combination for this game
        /// </summary>
        [JsonProperty(PropertyName = "mods")]
        [JsonConverter(typeof(ModsJSONConverter))]
        public Mods[] Mods { get; set; }

        /// <summary>
        /// List of <see cref="APIScore"/>s for all people who played during this game
        /// </summary>
        [JsonProperty(PropertyName = "scores")]
        public List<APIScore> Scores { get; set; }
    }
}