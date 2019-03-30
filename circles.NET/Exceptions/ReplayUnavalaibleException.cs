using System;

namespace circles.NET.Exceptions
{
    public class ReplayUnavalaibleException : Exception
    {
        public ReplayUnavalaibleException(string reason)
            : base($"The requested replay isn't avalaible : " + reason)
        {
        }
    }
}