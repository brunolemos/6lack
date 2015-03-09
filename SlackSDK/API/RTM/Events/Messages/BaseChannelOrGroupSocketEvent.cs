using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    [DataContract]
    public class BaseChannelOrGroupSocketEvent : MessageSocketEvent
    {
        public bool IsGroup { get; private set; }

        [DataMember(Name = "channel")]
        public new string ChannelOrGroupID { get { return channelOrGroupID; } protected set { channelOrGroupID = value; SetChannelOrGroup(); } }
        private string channelOrGroupID;

        private void SetChannelOrGroup()
        {
            IsGroup = ChannelOrGroupID?[0] == 'G';
        }
    }
}
