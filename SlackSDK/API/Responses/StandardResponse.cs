using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    [DataContract]
    public class StandardResponse
    {
        [DataMember(Name = "ok")]
        public bool? OK { get; private set; }

        [DataMember(Name = "error")]
        public string Error { get; private set; }
    }
}
