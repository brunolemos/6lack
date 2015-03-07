namespace SlackSDK.Exceptions
{
    /// <summary>
    /// This method cannot be called by a single channel guest.
    /// </summary>
    public class UserIsUltraRestrictedException : SlackException
    {
        public const string ID = "user_is_ultra_restricted";

        public UserIsUltraRestrictedException() : base() { }
        public UserIsUltraRestrictedException(string message) : base(message) { }
        public UserIsUltraRestrictedException(string message, UserIsUltraRestrictedException innerException) : base(message, innerException) { }
    }
}