using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A message_deleted message is sent when a message 
    /// in a channel is deleted, usually via the chat.delete method.
    /// 
    /// The deleted_ts property gives the timestamp of the message that was deleted.
    /// 
    /// If clients find an existing message with the same deleted_ts and channel, 
    /// the existing message should be removed from the local model and UI. 
    /// The original message will no longer return in history calls.
    /// 
    /// All types of messages are eligible for deletion, not just user-sent messages.
    /// </summary>
    [DataContract]
    public class MessageDeletedSocketEvent : MessageSocketEvent
    {
        public const string SUBTYPE = "message_deleted";

        [DataMember(Name = "deleted_ts")]
        public string DeletedMessageTimestamp { get; protected set; }
    }
}
