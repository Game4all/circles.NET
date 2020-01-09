using System;

namespace circles.NET.V1.Exceptions
{
    public class InvalidAPIKeyException : Exception
    {
        public InvalidAPIKeyException()
            : base($"The set API Key isn't a valid API key")
        {
        }
    }
}