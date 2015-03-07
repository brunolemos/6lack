namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user cannot invite themselves to a channel.
    /// </summary>
    public class CantInviteSelfException : SlackException
    {
        public const string ID = "cant_invite_self";

        public CantInviteSelfException() : base() { }
        public CantInviteSelfException(string message) : base(message) { }
        public CantInviteSelfException(string message, CantInviteSelfException innerException) : base(message, innerException) { }
    }
}
