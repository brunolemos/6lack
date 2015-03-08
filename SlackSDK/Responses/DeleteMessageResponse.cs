using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class DeleteMessageResponse : StandardResponse
    {
        [DataMember(Name = "channel")]
        public string ChannelID { get; private set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; private set; }
    }
}