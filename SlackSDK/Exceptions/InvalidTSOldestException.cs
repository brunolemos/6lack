namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'oldest' was invalid
    /// </summary>
    public class InvalidTSOldestException : SlackException
    {
        public const string ID = "invalid_ts_oldest";

        public InvalidTSOldestException() : base() { }
        public InvalidTSOldestException(string message) : base(message) { }
        public InvalidTSOldestException(string message, InvalidTSOldestException innerException) : base(message, innerException) { }
    }
}
