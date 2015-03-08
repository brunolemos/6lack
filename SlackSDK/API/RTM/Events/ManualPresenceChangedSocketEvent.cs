using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The manual_presence_change event is sent 
    /// to all connections for a user when that user manually updates their presence. 
    /// Clients can use this to update their local state.
    /// </summary>
    [DataContract]
    public class ManualPresenceChangedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "manual_presence_change";

        [DataMember(Name = "presence")]
        public UserPresence Presence { get; protected set; }
    }
}
