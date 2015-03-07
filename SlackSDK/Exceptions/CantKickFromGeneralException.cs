namespace SlackSDK.Exceptions
{
    /// <summary>
    /// User cannot be removed from #general.
    /// </summary>
    public class CantKickFromGeneralException : SlackException
    {
        public const string ID = "cant_kick_from_general";

        public CantKickFromGeneralException() : base() { }
        public CantKickFromGeneralException(string message) : base(message) { }
        public CantKickFromGeneralException(string message, CantKickFromGeneralException innerException) : base(message, innerException) { }
    }
}
