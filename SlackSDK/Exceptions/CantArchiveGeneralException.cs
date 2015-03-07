namespace SlackSDK.Exceptions
{
    /// <summary>
    /// You cannot archive the general channel
    /// </summary>
    public class CantArchiveGeneralException : SlackException
    {
        public const string ID = "cant_archive_general";

        public CantArchiveGeneralException() : base() { }
        public CantArchiveGeneralException(string message) : base(message) { }
        public CantArchiveGeneralException(string message, CantArchiveGeneralException innerException) : base(message, innerException) { }
    }
}