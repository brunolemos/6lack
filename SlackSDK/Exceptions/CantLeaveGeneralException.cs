namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Authenticated user cannot leave the general channel
    /// </summary>
    public class CantLeaveGeneralException : SlackException
    {
        public const string ID = "cant_leave_general";

        public CantLeaveGeneralException() : base() { }
        public CantLeaveGeneralException(string message) : base(message) { }
        public CantLeaveGeneralException(string message, CantLeaveGeneralException innerException) : base(message, innerException) { }
    }
}
