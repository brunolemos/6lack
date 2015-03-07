using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Messages : ObservableCollection<Message> { }

    [DataContract]
    public class Message : BaseModel
    {
        //"type": "message",
        //    "ts": "1358546515.000007",
        //    "user": "U2147483896",
        //    "text": "World",
        //    "is_starred": true,
        //    "wibblr": true
    }
}
