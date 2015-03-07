namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'name' was empty.
    /// </summary>
    public class NoChannelException : SlackException
    {
        public const string ID = "no_channel";

        public NoChannelException() : base() { }
        public NoChannelException(string message) : base(message) { }
        public NoChannelException(string message, NoChannelException innerException) : base(message, innerException) { }
    }
}
