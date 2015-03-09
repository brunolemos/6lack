using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    [DataContract]
    public abstract class BaseSocketEvent
    {
        [DataMember(Name = "type")]
        public string Type { get; private set; }

        //[DataMember(Name = "event_ts")]
        //public string EventTimestamp { get; private set; }
    }
}
