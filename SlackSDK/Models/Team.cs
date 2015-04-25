using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Teams : ObservableCollection<Team> { }

    [DataContract]
    public class Team : BaseModel
    {
        [DataMember(Name = "id")]
        public string ID { get; protected set; }

        [IgnoreDataMember]
        public Channels Channels { get { return channels; } internal set { if (channels != value) { channels = value; NotifyPropertyChanged("Channels"); } } }
        private Channels channels;

        [IgnoreDataMember]
        public Users Members { get { return members; } internal set { if (members != value) { members = value; NotifyPropertyChanged("Members"); } } }
        private Users members;

        [DataMember(Name = "name")]
        public string Name { get { return name; } set { if (name != value) { name = value; NotifyPropertyChanged("Name"); } } }
        private string name;

        [DataMember(Name = "email_domain")]
        public string EmailDomain { get { return emailDomain; } protected set { if (emailDomain != value) { emailDomain = value; NotifyPropertyChanged("EmailDomain"); } } }
        private string emailDomain;

        [DataMember(Name = "domain")]
        public string Domain { get { return domain; } protected set { if (domain != value) { domain = value; NotifyPropertyChanged("Domain"); } } }
        private string domain;

        [DataMember(Name = "msg_edit_window_mins")]
        public string MessageEditWindowMins { get { return messageEditWindowMins; } protected set { if (messageEditWindowMins != value) { messageEditWindowMins = value; NotifyPropertyChanged("MessageEditWindowMins"); } } }
        private string messageEditWindowMins;

        [DataMember(Name = "over_storage_limit")]
        public bool OverStorageLimit { get { return overStorageLimit; } protected set { if (overStorageLimit != value) { overStorageLimit = value; NotifyPropertyChanged("OverStorageLimit"); } } }
        private bool overStorageLimit;

        //prefs {...}
    }
}
