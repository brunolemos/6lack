namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user does not have permission to update this message.
    /// </summary>
    public class CantUpdateMessageException : SlackException
    {
        public const string ID = "cant_update_message";

        public CantUpdateMessageException() : base() { }
        public CantUpdateMessageException(string message) : base(message) { }
        public CantUpdateMessageException(string message, CantUpdateMessageException innerException) : base(message, innerException) { }
    }
}
