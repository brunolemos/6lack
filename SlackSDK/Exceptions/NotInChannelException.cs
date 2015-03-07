namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user is not in the channel.
    /// </summary>
    public class NotInChannelException : SlackException
    {
        public const string ID = "not_in_channel";

        public NotInChannelException() : base() { }
        public NotInChannelException(string message) : base(message) { }
        public NotInChannelException(string message, NotInChannelException innerException) : base(message, innerException) { }
    }
}
