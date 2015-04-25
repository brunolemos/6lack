using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A me_message is sent when a channel member performs an action using the /me command.
    /// </summary>
    [DataContract]
    public class MeMessageSocketEvent : MessageSocketEvent
    {
        public const string SUBTYPE = "me_message";

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }
    }
}
