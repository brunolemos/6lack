using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    [DataContract]
    public class PostMessageResponse : StandardResponse
    {
        [DataMember(Name = "ts")]
        public float Timestamp { get; private set; }

        [DataMember(Name = "channel")]
        public string ChannelID { get; private set; }

        [DataMember(Name = "message")]
        public Message Message { get; private set; }
    }
}