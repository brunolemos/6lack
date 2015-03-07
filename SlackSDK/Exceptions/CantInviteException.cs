namespace SlackSDK.Exceptions
{
    /// <summary>
    /// User cannot be invited to this channel.
    /// </summary>
    public class CantInviteException : SlackException
    {
        public const string ID = "cant_invite";

        public CantInviteException() : base() { }
        public CantInviteException(string message) : base(message) { }
        public CantInviteException(string message, CantInviteException innerException) : base(message, innerException) { }
    }
}
