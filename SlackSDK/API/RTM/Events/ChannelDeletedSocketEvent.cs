using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_deleted event is sent to all connections 
    /// for a team when a team channel is deleted. 
    /// Clients can use this to update their local cache of non-joined channels.
    /// </summary>
    [DataContract]
    public class ChannelDeletedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_deleted";

        [DataMember(Name = "channel")]
        public string ChannelID { get; protected set; }
    }
}
