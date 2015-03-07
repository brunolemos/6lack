namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authentication token is for a deleted user or team.
    /// </summary>
    public class AccountInactiveException : SlackException
    {
        public const string ID = "account_inactive";

        public AccountInactiveException() : base() { }
        public AccountInactiveException(string message) : base(message) { }
        public AccountInactiveException(string message, AccountInactiveException innerException) : base(message, innerException) { }
    }
}
