namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Message text is too long
    /// </summary>
    public class MessageTooLongException : SlackException
    {
        public const string ID = "msg_too_long";

        public MessageTooLongException() : base() { }
        public MessageTooLongException(string message) : base(message) { }
        public MessageTooLongException(string message, MessageTooLongException innerException) : base(message, innerException) { }
    }
}
