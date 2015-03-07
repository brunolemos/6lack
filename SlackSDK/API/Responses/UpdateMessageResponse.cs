using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    [DataContract]
    public class UpdateMessageResponse : StandardResponse
    {
        [DataMember(Name = "ts")]
        public float Timestamp { get; private set; }

        [DataMember(Name = "channel")]
        public string ChannelID { get; private set; }

        [DataMember(Name = "text")]
        public string Text { get; private set; }
    }
}