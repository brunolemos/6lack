namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Channel is not archived.
    /// </summary>
    public class NotArchivedException : SlackException
    {
        public const string ID = "not_archived";

        public NotArchivedException() : base() { }
        public NotArchivedException(string message) : base(message) { }
        public NotArchivedException(string message, NotArchivedException innerException) : base(message, innerException) { }
    }
}
