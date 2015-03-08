using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class AuthAccessResponse : StandardResponse
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; private set; }

        [DataMember(Name = "scope")]
        public string Scope { get; private set; }
    }
}
