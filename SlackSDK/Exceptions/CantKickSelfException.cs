namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user can't kick themselves from a channel.
    /// </summary>
    public class CantKickSelfException : SlackException
    {
        public const string ID = "cant_kick_self";

        public CantKickSelfException() : base() { }
        public CantKickSelfException(string message) : base(message) { }
        public CantKickSelfException(string message, CantKickSelfException innerException) : base(message, innerException) { }
    }
}
