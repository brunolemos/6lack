using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The presence_change event is sent to all connections 
    /// for a team when a user changes status. 
    /// Clients can use this to update their local list of users.
    /// 
    /// If a user updates their presence manually, 
    /// the manual_presence_change event will also be sent 
    /// to all connected clients for that user.
    /// </summary>
    [DataContract]
    public class PresenceChangedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "presence_change";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "presence")]
        public UserPresence Presence { get; protected set; }
    }
}
