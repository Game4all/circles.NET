using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! ongoing or finished multiplayer room returned by API
    /// </summary>
    public sealed class APIMultiplayerRoom
    {
        [JsonProperty(PropertyName = "games")]
        public APIMultiplayerGame[] Games { get; set; }

        [JsonProperty(PropertyName = "match")]
        public APIMultiplayerRoomInfo Info { get; set; }
    }
}