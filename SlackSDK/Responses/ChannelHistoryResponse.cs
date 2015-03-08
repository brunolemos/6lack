using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class ChannelHistoryResponse : StandardResponse
    {
        [DataMember(Name = "latest")]
        public string Latest { get; private set; }

        [DataMember(Name = "messages")]
        public Messages Messages { get; private set; }

        [DataMember(Name = "has_more")]
        public bool HasMore { get; private set; }

        [DataMember(Name = "is_limited")]
        public bool IsLimited { get; private set; }
    }
}