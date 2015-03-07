namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'client_secret' was invalid.
    /// </summary>
    public class BadClientSecretException : SlackException
    {
        public const string ID = "bad_client_secret";

        public BadClientSecretException() : base() { }
        public BadClientSecretException(string message) : base(message) { }
        public BadClientSecretException(string message, BadClientSecretException innerException) : base(message, innerException) { }
    }
}
