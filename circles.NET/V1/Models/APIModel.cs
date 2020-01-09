using circles.NET.V1.Exceptions;
using Newtonsoft.Json;

namespace circles.NET.V1.Models
{
    public class APIModel
    {
        internal APIModel()
        {
        }

        [JsonProperty(PropertyName = "error")] //super hacky way of throwing if error field is set
        internal string Error { set { throw new APIErrorException(value); } }
    }
}