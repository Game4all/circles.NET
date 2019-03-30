using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! ongoing or finished multiplayer room returned by API
    /// </summary>
    public sealed class APIMultiplayerRoom
    {
        /// <summary>
        /// List of pasts and ongoing games
        /// </summary>
        [JsonProperty(PropertyName = "games")]
        public APIMultiplayerGame[] Games { get; set; }

        /// <summary>
        /// Info about this <see cref="APIMultiplayerRoom"/>
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public APIMultiplayerRoomInfo Info { get; set; }
    }
}