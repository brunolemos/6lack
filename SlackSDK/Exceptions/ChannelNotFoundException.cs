namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'channel' was invalid.
    /// </summary>
    public class ChannelNotFoundException : SlackException
    {
        public const string ID = "channel_not_found";

        public ChannelNotFoundException() : base() { }
        public ChannelNotFoundException(string message) : base(message) { }
        public ChannelNotFoundException(string message, ChannelNotFoundException innerException) : base(message, innerException) { }
    }
}
