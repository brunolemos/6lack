namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Channel has been archived.
    /// </summary>
    public class IsArchivedException : SlackException
    {
        public const string ID = "is_archived";

        public IsArchivedException() : base() { }
        public IsArchivedException(string message) : base(message) { }
        public IsArchivedException(string message, IsArchivedException innerException) : base(message, innerException) { }
    }
}
