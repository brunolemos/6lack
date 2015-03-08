using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_joined event is sent to all connections 
    /// for a user when that user joins a channel. 
    /// In addition to this message, all existing members of the channel 
    /// will recieve a channel_join message event.
    /// </summary>
    [DataContract]
    public class ChannelJoinedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_joined";

        [DataMember(Name = "channel")]
        public Channel Channel { get; protected set; }
    }
}
