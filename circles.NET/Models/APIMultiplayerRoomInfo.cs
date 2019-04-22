using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// Information about an ongoing or finished <see cref="APIMultiplayerRoom"/>
    /// </summary>
    public sealed class APIMultiplayerRoomInfo : APIModel
    {
        /// <summary>
        /// The ID of this multiplayer room
        /// </summary>
        [JsonProperty(PropertyName = "match_id")]
        public long MatchId { get; private set; }

        /// <summary>
        /// The display name of this multiplayer room
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// The time at which this room was created
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; private set; }

        /// <summary>
        /// The time at which this room was deleted (can be null if it's still ongoing)
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; private set; }
    }
}