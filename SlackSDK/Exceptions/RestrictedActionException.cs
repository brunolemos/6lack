namespace SlackSDK.Exceptions
{
    /// <summary>
    /// A team preference prevents from executing this action.
    /// </summary>
    public class RestrictedActionException : SlackException
    {
        public const string ID = "restricted_action";

        public RestrictedActionException() : base() { }
        public RestrictedActionException(string message) : base(message) { }
        public RestrictedActionException(string message, RestrictedActionException innerException) : base(message, innerException) { }
    }
}