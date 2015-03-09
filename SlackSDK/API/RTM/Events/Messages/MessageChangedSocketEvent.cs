using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A message_changed message is sent when a message 
    /// in a channel is edited using the chat.update method. 
    /// The message property contains the updated message object.
    /// 
    /// When clients recieve this message type, 
    /// they should look for an existing message with the same message.ts in that channel. 
    /// If they find one the existing message should be replaced with the new one.
    /// </summary>
    [DataContract]
    public class MessageChangedSocketEvent : MessageSocketEvent
    {
        public const string SUBTYPE = "message_changed";
        
        [DataMember(Name = "message")]
        public Message Message { get; protected set; }
    }
}
