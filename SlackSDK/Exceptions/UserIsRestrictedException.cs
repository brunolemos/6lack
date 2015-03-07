namespace SlackSDK.Exceptions
{
    /// <summary>
    /// This method cannot be called by a restricted user or single channel guest.
    /// </summary>
    public class UserIsRestrictedException : SlackException
    {
        public const string ID = "user_is_restricted";

        public UserIsRestrictedException() : base() { }
        public UserIsRestrictedException(string message) : base(message) { }
        public UserIsRestrictedException(string message, UserIsRestrictedException innerException) : base(message, innerException) { }
    }
}