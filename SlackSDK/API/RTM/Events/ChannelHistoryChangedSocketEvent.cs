using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// A channel_history_changed event is sent to all clients in a channel 
    /// when bulk changes have occured to that channel's history. 
    /// When clients recieve this message they should reload chat history 
    /// for the channel if they have any cached messages before latest.
    /// </summary>
    [DataContract]
    public class ChannelHistoryChangedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_history_changed";

        [DataMember(Name = "latest")]
        public string Latest { get; protected set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; protected set; }

        [DataMember(Name = "event_ts")]
        public string EventTimestamp { get; protected set; }
    }
}
