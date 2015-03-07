namespace SlackSDK.Exceptions
{
    /// <summary>
    /// This method cannot be called by a bot user.
    /// </summary>
    public class UserIsBotException : SlackException
    {
        public const string ID = "user_is_bot";

        public UserIsBotException() : base() { }
        public UserIsBotException(string message) : base(message) { }
        public UserIsBotException(string message, UserIsBotException innerException) : base(message, innerException) { }
    }
}