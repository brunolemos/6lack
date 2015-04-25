using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_purpose message is sent when the purpose 
    /// for a channel is changed using the channel.setPurpose method.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupPurposeSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_purpose";
        public const string SUBTYPE2 = "group_purpose";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "purpose")]
        public string Purpose { get; protected set; }
    }
}
