using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.Responses
{
    [DataContract]
    public class RealtimeStartResponse : StandardResponse
    {
        [DataMember(Name = "url")]
        public string URL { get; private set; }

        [DataMember(Name = "self")]
        public User Self { get; private set; }

        [DataMember(Name = "team")]
        public Team Team { get; private set; }

        [DataMember(Name = "users")]
        public Users Users { get; private set; }

        [DataMember(Name = "channels")]
        public Channels Channels { get; private set; }

        //[DataMember(Name = "groups")]
        //public Groups Groups { get; private set; }

        //[DataMember(Name = "ims")]
        //public IMs IMs { get; private set; }

        //[DataMember(Name = "bots")]
        //public Bots Bots { get; private set; }
    }
}
