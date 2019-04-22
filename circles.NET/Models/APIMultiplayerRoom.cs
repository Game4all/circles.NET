using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! ongoing or finished multiplayer room returned by API
    /// </summary>
    public sealed class APIMultiplayerRoom : APIModel
    {
        /// <summary>
        /// List of pasts and ongoing games
        /// </summary>
        [JsonProperty(PropertyName = "games")]
        public APIMultiplayerGame[] Games { get; private set; }

        /// <summary>
        /// Info about this <see cref="APIMultiplayerRoom"/>
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public APIMultiplayerRoomInfo Info { get; private set; }
    }
}