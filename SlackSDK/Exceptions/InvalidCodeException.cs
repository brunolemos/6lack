namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'code' was invalid.
    /// </summary>
    public class InvalidCodeException : SlackException
    {
        public const string ID = "invalid_code";

        public InvalidCodeException() : base() { }
        public InvalidCodeException(string message) : base(message) { }
        public InvalidCodeException(string message, InvalidCodeException innerException) : base(message, innerException) { }
    }
}
