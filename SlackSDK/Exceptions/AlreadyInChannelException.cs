namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Invited user is already in the channel.
    /// </summary>
    public class AlreadyInChannelException : SlackException
    {
        public const string ID = "already_in_channel";

        public AlreadyInChannelException() : base() { }
        public AlreadyInChannelException(string message) : base(message) { }
        public AlreadyInChannelException(string message, AlreadyInChannelException innerException) : base(message, innerException) { }
    }
}
