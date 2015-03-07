using SlackSDK.Common;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Channels : ObservableCollection<Channel> { }

    [DataContract]
    public class Channel : BaseModel
    {
        [DataMember(Name = "id")]
        public string ID { get; protected set; }

        [DataMember(Name = "name")]
        public string Name { get { return name; } protected set { if (name != value) { name = value; NotifyPropertyChanged("Name"); } } }
        private string name;

        [DataMember(Name = "is_channel")]
        public bool IsChannel { get { return true; } }

        [DataMember(Name = "is_archived")]
        public bool IsArchived { get { return isArchived; } protected set { if (isArchived != value) { isArchived = value; NotifyPropertyChanged("IsArchived"); } } }
        private bool isArchived;

        [DataMember(Name = "is_general")]
        public bool IsGeneral { get { return isGeneral; } protected set { if (isGeneral != value) { isGeneral = value; NotifyPropertyChanged("IsGeneral"); } } }
        private bool isGeneral;

        [DataMember(Name = "created")]
        public float CreatedAt { get; protected set; }

        [DataMember(Name = "creator")]
        public string CreatedBy { get; protected set; }

        [DataMember(Name = "members")]
        public ObservableCollection<string> Members { get; } = new ObservableCollection<string>();

        [DataMember(Name = "topic")]
        public Topic Topic { get { return topic; } protected set { if (topic != value) { topic = value; NotifyPropertyChanged("Topic"); } } }
        private Topic topic;

        [DataMember(Name = "purpose")]
        public Purpose Purpose { get { return purpose; } protected set { if (purpose != value) { purpose = value; NotifyPropertyChanged("Purpose"); } } }
        private Purpose purpose;

        [DataMember(Name = "is_member")]
        public bool IsMember { get { return isMember; } protected set { if (isMember != value) { isMember = value; NotifyPropertyChanged("IsMember"); } } }
        private bool isMember;

        [DataMember(Name = "last_read")]
        public float LastReadAt { get { return lastReadAt; } protected set { if (lastReadAt != value) { lastReadAt = value; NotifyPropertyChanged("LastReadAt"); } } }
        private float lastReadAt;

        [DataMember(Name = "unread_count")]
        public uint UnreadCount { get { return unreadCount; } protected set { if (unreadCount != value) { unreadCount = value; NotifyPropertyChanged("UnreadCount"); } } }
        private uint unreadCount;

        [DataMember(Name = "unread_count_display")]
        public uint UnreadCountDisplay { get { return unreadCountDisplay; } protected set { if (unreadCountDisplay != value) { unreadCountDisplay = value; NotifyPropertyChanged("UnreadCountDisplay"); } } }
        private uint unreadCountDisplay;

        [DataMember(Name = "latest")]
        public Message LastestMessage { get { return lastestMessage; } protected set { if (lastestMessage != value) { lastestMessage = value; NotifyPropertyChanged("LastestMessage"); } } }
        private Message lastestMessage;
    }

    [DataContract]
    public class Topic : Purpose
    {
    }

    [DataContract]
    public class Purpose : Notifiable
    {

        [DataMember(Name = "value")]
        public string Value { get { return value; } protected set { if (this.value != value) { this.value = value; NotifyPropertyChanged("Value"); } } }
        private string value;

        [DataMember(Name = "creator")]
        public string CreatedBy { get { return createdBy; } protected set { if (createdBy != value) { createdBy = value; NotifyPropertyChanged("CreatedBy"); } } }
        private string createdBy;

        [DataMember(Name = "last_set")]
        public float UpdatedAt { get { return updatedAt; } protected set { if (updatedAt != value) { updatedAt = value; NotifyPropertyChanged("UpdatedAt"); } } }
        private float updatedAt;
    }
}
