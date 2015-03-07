namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Value passed for 'redirect_uri' did not match the 'redirect_uri' in the original request.
    /// </summary>
    public class BadRedirectUriException : SlackException
    {
        public const string ID = "bad_redirect_uri";

        public BadRedirectUriException() : base() { }
        public BadRedirectUriException(string message) : base(message) { }
        public BadRedirectUriException(string message, BadRedirectUriException innerException) : base(message, innerException) { }
    }
}
