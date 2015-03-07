namespace SlackSDK.Exceptions
{
    /// <summary>
    /// You cannot archive the last channel for a restricted account
    /// </summary>
    public class LastRestrictedAccountChannel : SlackException
    {
        public const string ID = "last_ra_channel";

        public LastRestrictedAccountChannel() : base() { }
        public LastRestrictedAccountChannel(string message) : base(message) { }
        public LastRestrictedAccountChannel(string message, LastRestrictedAccountChannel innerException) : base(message, innerException) { }
    }
}