namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Application has posted too many messages
    /// </summary>
    public class RateLimitedException : SlackException
    {
        public const string ID = "rate_limited";

        public RateLimitedException() : base() { }
        public RateLimitedException(string message) : base(message) { }
        public RateLimitedException(string message, RateLimitedException innerException) : base(message, innerException) { }
    }
}
