namespace SlackSDK.Exceptions
{
    /// <summary>
    /// No message text provided
    /// </summary>
    public class NoTextException : SlackException
    {
        public const string ID = "no_text";

        public NoTextException() : base() { }
        public NoTextException(string message) : base(message) { }
        public NoTextException(string message, NoTextException innerException) : base(message, innerException) { }
    }
}
