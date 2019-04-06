using circles.NET.Exceptions;
using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing replay data returned by API
    /// </summary>
    public sealed class APIReplay
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; private set; }

        [JsonProperty(PropertyName = "error")] //super hacky way of throwing if error field is set
        internal string Error { set { throw new ReplayUnavalaibleException(value); } }
    }
}