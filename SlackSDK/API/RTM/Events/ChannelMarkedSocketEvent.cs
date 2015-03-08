using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_marked event is sent to all open connections 
    /// for a user when that user moves the read cursor in a channel 
    /// by calling the channels.mark API method.
    /// </summary>
    [DataContract]
    public class ChannelMarkedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_marked";

        [DataMember(Name = "channel")]
        public string ChannelID { get; protected set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; protected set; }
    }
}
