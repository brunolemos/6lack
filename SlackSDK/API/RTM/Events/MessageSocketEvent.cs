using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// A message is delivered from several sources:
    /// - They are sent via the Real Time Messaging API when a message 
    /// is sent to a channel to which you subscribe.This message should 
    /// immediately be displayed in the client.
    /// - They are returned via calls to channels.history, 
    /// im.history or groups.history
    /// - They are returned as latest property on channel, group and im objects.
    /// </summary>
    [DataContract]
    public abstract class MessageSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "message";

        [DataMember(Name = "subtype")]
        public string SubType { get; private set; }

        [DataMember(Name = "hidden")]
        public bool IsHidden { get; private set; }

        [DataMember(Name = "channel")]
        public string ChannelOrGroupID { get; protected set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; protected set; }
    }
}
