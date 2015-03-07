using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    public class TopicChannelResponse : StandardResponse
    {
        [DataMember(Name = "topic")]
        public string Topic { get; private set; }
    }
}
