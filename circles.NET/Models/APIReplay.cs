using Newtonsoft.Json;

namespace circles.NET.Models
{
    public sealed class APIReplay
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}
