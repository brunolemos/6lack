using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_created event is sent to all connections 
    /// for a team when a new team channel is created. 
    /// Clients can use this to update their local cache of non-joined channels.
    /// </summary>
    [DataContract]
    public class ChannelCreatedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_created";

        [DataMember(Name = "channel")]
        public Channel Channel { get; protected set; }
    }
}
