using System;

namespace circles.NET.Exceptions
{
    public class InvalidAPIKeyException : Exception
    {
        public InvalidAPIKeyException()
            : base($"The set API Key isn't a valid API key")
        {
        }
    }
}