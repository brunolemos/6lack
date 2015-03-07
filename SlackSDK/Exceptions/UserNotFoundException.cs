namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'user' was invalid.
    /// </summary>
    public class UserNotFoundException : SlackException
    {
        public const string ID = "user_not_found";

        public UserNotFoundException() : base() { }
        public UserNotFoundException(string message) : base(message) { }
        public UserNotFoundException(string message, UserNotFoundException innerException) : base(message, innerException) { }
    }
}
