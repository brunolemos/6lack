using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class ChannelResponse : StandardResponse
    {
        [DataMember(Name = "channel")]
        public Channel Channel { get; private set; }
    }
}