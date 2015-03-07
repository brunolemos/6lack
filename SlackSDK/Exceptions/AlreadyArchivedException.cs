namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Channel has already been archived.
    /// </summary>
    public class AlreadyArchivedException : SlackException
    {
        public const string ID = "already_archived";

        public AlreadyArchivedException() : base() { }
        public AlreadyArchivedException(string message) : base(message) { }
        public AlreadyArchivedException(string message, AlreadyArchivedException innerException) : base(message, innerException) { }
    }
}

