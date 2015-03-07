namespace SlackSDK.Exceptions
{
    /// <summary>
    /// No authentication token provided.
    /// </summary>
    public class NotAuthedException : SlackException
    {
        public const string ID = "not_authed";

        public NotAuthedException() : base() { }
        public NotAuthedException(string message) : base(message) { }
        public NotAuthedException(string message, NotAuthedException innerException) : base(message, innerException) { }
    }
}
