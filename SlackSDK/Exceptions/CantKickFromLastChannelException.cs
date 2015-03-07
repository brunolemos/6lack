namespace SlackSDK.Exceptions
{
    /// <summary>
    /// User cannot be removed from the last channel they're in.
    /// </summary>
    public class CantKickFromLastChannelException : SlackException
    {
        public const string ID = "cant_kick_from_last_channel";

        public CantKickFromLastChannelException() : base() { }
        public CantKickFromLastChannelException(string message) : base(message) { }
        public CantKickFromLastChannelException(string message, CantKickFromLastChannelException innerException) : base(message, innerException) { }
    }
}
