using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    public class JoinChannelResponse : ChannelResponse
    {
        [DataMember(Name = "already_in_channel")]
        public bool? AlreadyInChannel { get; private set; }
    }
}
