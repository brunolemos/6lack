using SlackSDK.Common;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Messages : ObservableCollection<Message> { }

    [DataContract]
    public class Message : BaseModel
    {
        //[DataMember(Name = "channel")]
        //public string ChannelID { get; protected set; }

        [DataMember(Name = "user")]
        public string UserID { get; protected set; }

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
