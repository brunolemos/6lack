using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_leave message is sent when a member of a channel leaves that channel.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupLeaveSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_leave";
        public const string SUBTYPE2 = "group_leave";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }
    }
}
