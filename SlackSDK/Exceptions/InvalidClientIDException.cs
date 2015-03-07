namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'client_id' was invalid.
    /// </summary>
    public class InvalidClientIDException : SlackException
    {
        public const string ID = "invalid_client_id";

        public InvalidClientIDException() : base() { }
        public InvalidClientIDException(string message) : base(message) { }
        public InvalidClientIDException(string message, InvalidClientIDException innerException) : base(message, innerException) { }
    }
}
