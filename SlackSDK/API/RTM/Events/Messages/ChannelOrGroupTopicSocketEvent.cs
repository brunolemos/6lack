using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_topic message is sent when the topic for a channel is changed.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupTopicSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_topic";
        public const string SUBTYPE2 = "group_topic";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "topic")]
        public string Topic { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }
    }
}
