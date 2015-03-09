using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_name message is sent when a channel is renamed.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupNameSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_name";
        public const string SUBTYPE2 = "group_name";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "old_name")]
        public string OldName { get; protected set; }

        [DataMember(Name = "name")]
        public string Name { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }
    }
}
