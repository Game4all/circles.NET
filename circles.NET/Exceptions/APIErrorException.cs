using System;

namespace circles.NET.Exceptions
{
    public class APIErrorException : Exception
    {
        public APIErrorException(string reason)
            : base($"The API returned the following error :" + reason)
        {
        }
    }
}