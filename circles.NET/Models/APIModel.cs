using circles.NET.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace circles.NET.Models
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
