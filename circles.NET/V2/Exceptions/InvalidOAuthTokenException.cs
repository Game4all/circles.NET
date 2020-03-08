using System;

namespace circles.NET.V2.Exceptions
{
    public class InvalidOAuthTokenException : Exception
    {
        public InvalidOAuthTokenException()
            : base("The provided OAuth token is not valid.")
        {
        }
    }
}