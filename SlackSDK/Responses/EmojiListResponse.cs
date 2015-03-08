using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class EmojiListResponse : StandardResponse
    {
        [DataMember(Name = "emoji")]
        public Emojis Emojis { get; private set; }
    }
}