using System;

namespace circles.NET.Exceptions
{
    public class InvalidAPIKeyException : Exception
    {
        public InvalidAPIKeyException(string apiKey)
            : base($"The API Key \"{apiKey}\" isn't a valid API key")
        {
        }
    }
}