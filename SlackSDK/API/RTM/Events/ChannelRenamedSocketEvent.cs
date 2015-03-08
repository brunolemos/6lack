using SlackSDK.Common;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_renamed event is sent to all connections 
    /// for a team when a team channel is renamed. 
    /// Clients can use this to update their local list of channels.
    /// </summary>
    [DataContract]
    public class ChannelRenamedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_rename";

        [DataMember(Name = "channel")]
        public RenamedChannel Channel { get; protected set; }
    }

    public class RenamedChannel : Notifiable
    {
        [DataMember(Name = "id")]
        public string ID { get; protected set; }

        [DataMember(Name = "name")]
        public string Name { get { return name; } protected set { if (name != value) { name = value; NotifyPropertyChanged("Name"); } } }
        private string name;

        [DataMember(Name = "created")]
        public string CreatedAt { get; protected set; }
    }
}
