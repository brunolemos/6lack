using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    public class TopicChannelResponse : StandardResponse
    {
        [DataMember(Name = "topic")]
        public string Topic { get; private set; }
    }
}
