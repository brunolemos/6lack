namespace SlackSDK.Exceptions
{
    /// <summary>
    /// No message exists with the requested timestamp.
    /// </summary>
    public class MessageNotFoundException : SlackException
    {
        public const string ID = "message_not_found";

        public MessageNotFoundException() : base() { }
        public MessageNotFoundException(string message) : base(message) { }
        public MessageNotFoundException(string message, MessageNotFoundException innerException) : base(message, innerException) { }
    }
}
