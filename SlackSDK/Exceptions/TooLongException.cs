namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Topic/Purpose was longer than 250 characters.
    /// </summary>
    public class TooLongException : SlackException
    {
        public const string ID = "too_long";

        public TooLongException() : base() { }
        public TooLongException(string message) : base(message) { }
        public TooLongException(string message, TooLongException innerException) : base(message, innerException) { }
    }
}
