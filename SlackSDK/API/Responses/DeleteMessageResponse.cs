using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    [DataContract]
    public class DeleteMessageResponse : StandardResponse
    {
        [DataMember(Name = "channel")]
        public string ChannelID { get; private set; }

        [DataMember(Name = "ts")]
        public float Timestamp { get; private set; }
    }
}