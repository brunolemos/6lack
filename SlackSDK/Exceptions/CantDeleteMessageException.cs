namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user does not have permission to delete this message.
    /// </summary>
    public class CantDeleteMessageException : SlackException
    {
        public const string ID = "cant_delete_message";

        public CantDeleteMessageException() : base() { }
        public CantDeleteMessageException(string message) : base(message) { }
        public CantDeleteMessageException(string message, CantDeleteMessageException innerException) : base(message, innerException) { }
    }
}
