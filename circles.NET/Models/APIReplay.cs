using circles.NET.Exceptions;
using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing replay data returned by API
    /// </summary>
    public sealed class APIReplay : APIModel
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; private set; }
    }
}