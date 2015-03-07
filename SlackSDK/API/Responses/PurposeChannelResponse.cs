using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    public class PurposeChannelResponse : StandardResponse
    {
        [DataMember(Name = "purpose")]
        public string Purpose { get; private set; }
    }
}
