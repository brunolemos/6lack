namespace SlackSDK.Exceptions
{
    /// <summary>
    /// New name is invalid
    /// </summary>
    public class InvalidNameException : SlackException
    {
        public const string ID = "invalid_name";

        public InvalidNameException() : base() { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, InvalidNameException innerException) : base(message, innerException) { }
    }
}
