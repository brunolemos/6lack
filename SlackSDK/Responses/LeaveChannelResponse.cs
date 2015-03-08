using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    public class LeaveChannelResponse : ChannelResponse
    {
        [DataMember(Name = "not_in_channel")]
        public bool? NotInChannel { get; private set; }
    }
}
