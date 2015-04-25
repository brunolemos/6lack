using SlackSDK.API.RTM.Events;
using SlackSDK.Common;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Messages : ObservableCollection<Message> { }

    [DataContract]
    public class Message : BaseModel
    {
        public Message() {}

        public Message(MessageSocketEvent socketEvent)
        {
            ChannelOrGroupID = socketEvent.ChannelOrGroupID;
            Text = socketEvent.Text;
            Timestamp = socketEvent.Timestamp;
        }

        [DataMember(Name = "channel")]
        public string ChannelOrGroupID { get; protected set; }

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [IgnoreDataMember]
        public User User { get { return string.IsNullOrEmpty(UserID) ? null : SlackClient.Users.Where(user => user.ID == UserID).FirstOrDefault(); } }

        [DataMember(Name = "text")]
        public string Text { get; protected set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; protected set; }

        //"attachments": []
        //"is_starred": true,
        //"wibblr": true
    }

    public class EditedMessage : Notifiable
    {
        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

        [DataMember(Name = "ts")]
        public string Timestamp { get; protected set; }
    }
}
