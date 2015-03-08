using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_archive event is sent to all connections 
    /// for a team when a team channel is archived. 
    /// Clients can use this to update their local list of channels.
    /// </summary>
    [DataContract]
    public class ChannelArchivedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_archive";

        [DataMember(Name = "channel")]
        public string ChannelID { get; protected set; }

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }
    }
}
