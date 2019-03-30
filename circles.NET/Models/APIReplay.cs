using circles.NET.Exceptions;
using Newtonsoft.Json;

namespace circles.NET.Models
{
    public sealed class APIReplay
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "error")]
        internal string Error { set { throw new ReplayUnavalaibleException(value); } }
    }
}