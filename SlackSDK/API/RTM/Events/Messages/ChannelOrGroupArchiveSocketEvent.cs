using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_archive message is sent when a channel is archived.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupArchiveSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_archive";
        public const string SUBTYPE2 = "group_archive";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }

        [DataMember(Name = "members")]
        public string[] Members { get; protected set; }
    }
}
