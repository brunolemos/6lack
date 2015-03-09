using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A channel_join message is sent when a team member joins a channel.
    /// 
    /// If the user was invited, the message will include 
    /// an inviter property containing the user ID of the inviting user.
    /// </summary>
    [DataContract]
    public class ChannelOrGroupJoinSocketEvent : BaseChannelOrGroupSocketEvent
    {
        public const string SUBTYPE = "channel_join";
        public const string SUBTYPE2 = "group_join";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }

        [DataMember(Name = "inviter")]
        public string InvitedBy { get; protected set; }
    }
}
