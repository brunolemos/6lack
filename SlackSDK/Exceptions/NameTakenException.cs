namespace SlackSDK.Exceptions
{
    /// <summary>
    /// The name specified has already been used.
    /// </summary>
    public class NameTakenException : SlackException
    {
        public const string ID = "name_taken";

        public NameTakenException() : base() { }
        public NameTakenException(string message) : base(message) { }
        public NameTakenException(string message, NameTakenException innerException) : base(message, innerException) { }
    }
}
