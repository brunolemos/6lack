using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_unarchive message is sent when a channel is unarchived.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupUnarchiveSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_unarchive";
        public const string SUBTYPE2 = "group_unarchive";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }
    }
}
