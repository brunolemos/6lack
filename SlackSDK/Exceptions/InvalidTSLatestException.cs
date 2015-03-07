namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'latest' was invalid
    /// </summary>
    public class InvalidTSLatestException : SlackException
    {
        public const string ID = "invalid_ts_latest";

        public InvalidTSLatestException() : base() { }
        public InvalidTSLatestException(string message) : base(message) { }
        public InvalidTSLatestException(string message, InvalidTSLatestException innerException) : base(message, innerException) { }
    }
}
