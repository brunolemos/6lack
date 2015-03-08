using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The pref_change event is sent to all connections 
    /// for a user when a user preference is changed. 
    /// Clients should update to reflect new changes immediately.
    /// </summary>
    [DataContract]
    public class PrefChangedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "pref_change";

        [DataMember(Name = "name")]
        public string Name { get; protected set; }

        [DataMember(Name = "value")]
        public string Value { get; protected set; }
    }
}
