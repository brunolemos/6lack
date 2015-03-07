using System;

namespace SlackSDK.Exceptions
{
    public abstract class SlackException : Exception
    {
        public SlackException() : base() { }
        public SlackException(string message) : base(message) { }
        public SlackException(string message, SlackException innerException) : base(message, innerException) { }
    }
}
