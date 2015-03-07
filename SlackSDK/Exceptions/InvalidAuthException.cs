namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Invalid authentication token.
    /// </summary>
    public class InvalidAuthException : SlackException
    {
        public const string ID = "invalid_auth";

        public InvalidAuthException() : base() { }
        public InvalidAuthException(string message) : base(message) { }
        public InvalidAuthException(string message, InvalidAuthException innerException) : base(message, innerException) { }
    }
}
