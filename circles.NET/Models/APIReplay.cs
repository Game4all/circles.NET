using circles.NET.Exceptions;
using Newtonsoft.Json;

namespace circles.NET.Models
{
    public sealed class APIReplay
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "error")] //super hacky way of throwing if error field is set
        internal string Error { set { throw new ReplayUnavalaibleException(value); } }
    }
}