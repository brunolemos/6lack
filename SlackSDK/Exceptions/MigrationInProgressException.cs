namespace SlackSDK.Exceptions
{
    /// <summary>
    /// Team is being migrated between servers. 
    /// </summary>
    public class MigrationInProgressException : SlackException
    {
        public const string ID = "migration_in_progress";

        public MigrationInProgressException() : base() { }
        public MigrationInProgressException(string message) : base(message) { }
        public MigrationInProgressException(string message, MigrationInProgressException innerException) : base(message, innerException) { }
    }
}
