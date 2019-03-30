using Newtonsoft.Json;

namespace circles.NET.Models
{
    public sealed class APIMultiplayerRoom
    {
        [JsonProperty(PropertyName = "games")]
        public APIMultiplayerGame[] Games { get; set; }

        [JsonProperty(PropertyName = "match")]
        public APIMultiplayerRoomInfo Info { get; set; }
    }
}