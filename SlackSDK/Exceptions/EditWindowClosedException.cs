namespace SlackSDK.Exceptions
{
    /// <summary>
    /// The message cannot be edited due to the team message edit settings
    /// </summary>
    public class EditWindowClosedException : SlackException
    {
        public const string ID = "edit_window_closed";

        public EditWindowClosedException() : base() { }
        public EditWindowClosedException(string message) : base(message) { }
        public EditWindowClosedException(string message, EditWindowClosedException innerException) : base(message, innerException) { }
    }
}
