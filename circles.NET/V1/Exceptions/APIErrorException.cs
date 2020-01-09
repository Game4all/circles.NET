using System;

namespace circles.NET.V1.Exceptions
{
    public class APIErrorException : Exception
    {
        public APIErrorException(string reason)
            : base($"The API returned the following error :" + reason)
        {
        }
    }
}