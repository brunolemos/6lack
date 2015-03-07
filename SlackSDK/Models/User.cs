using SlackSDK.Common;
using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Windows.UI;

namespace SlackSDK.Models
{
    public class Users : ObservableCollection<User> { }

    [DataContract]
    public class User : BaseModel
    {
        [DataMember(Name = "manual_presence")]
        public UserPresence Presence { get { return presence; } protected set { if (value != presence) { presence = value; NotifyPropertyChanged("Presence"); } } }
        private UserPresence presence = UserPresence.AWAY;

        [DataMember(Name = "id")]
        public string ID { get; protected set; }

        [DataMember(Name = "name")]
        public string Name { get { return name; } set { if (name != value) { name = value; NotifyPropertyChanged("Name"); } } }
        private string name;

        [DataMember(Name = "profile")]
        public UserProfile Profile { get { return profile; } protected set { if (profile != value) { profile = value; NotifyPropertyChanged("Profile"); } } }
        private UserProfile profile = new UserProfile();

        [DataMember(Name = "color")]
        public string Color { get { return color; } set { if (color != value) { color = value; NotifyPropertyChanged("Color"); } } }
        private string color;

        [DataMember(Name = "deleted")]
        public bool IsDeleted { get { return isDeleted; } protected set { if (isDeleted != value) { isDeleted = value; NotifyPropertyChanged("IsDeleted"); } } }
        private bool isDeleted;

        [DataMember(Name = "is_admin")]
        public bool IsAdmin { get { return isAdmin; } protected set { if (isAdmin != value) { isAdmin = value; NotifyPropertyChanged("IsAdmin"); } } }
        private bool isAdmin;

        [DataMember(Name = "is_owner")]
        public bool IsOwner { get { return isOwner; } protected set { if (isOwner != value) { isOwner = value; NotifyPropertyChanged("IsOwner"); } } }
        private bool isOwner;

        [DataMember(Name = "is_primary_owner")]
        public bool IsPrimaryOwner { get { return isPrimaryOwner; } protected set { if (isPrimaryOwner != value) { isPrimaryOwner = value; NotifyPropertyChanged("IsPrimaryOwner"); } } }
        private bool isPrimaryOwner;

        [DataMember(Name = "is_restricted")]
        public bool IsRestricted { get { return isRestricted; } protected set { if (isRestricted != value) { isRestricted = value; NotifyPropertyChanged("IsRestricted"); } } }
        private bool isRestricted;

        [DataMember(Name = "is_ultra_restricted")]
        public bool IsUltraRestricted { get { return isUltraRestricted; } protected set { if (isUltraRestricted != value) { isUltraRestricted = value; NotifyPropertyChanged("IsUltraRestricted"); } } }
        private bool isUltraRestricted;

        [DataMember(Name = "has_files")]
        public bool HasFiles { get { return hasFiles; } protected set { if (hasFiles != value) { hasFiles = value; NotifyPropertyChanged("HasFiles"); } } }
        private bool hasFiles;
    }

    [DataContract]
    public class UserProfile : Notifiable
    {
        [DataMember(Name = "first_name")]
        public string FirstName { get { return firstName; } set { if (firstName != value) { firstName = value; NotifyPropertyChanged("FirstName"); } } }
        private string firstName;

        [DataMember(Name = "last_name")]
        public string LastName { get { return lastName; } set { if (lastName != value) { lastName = value; NotifyPropertyChanged("LastName"); } } }
        private string lastName;

        [DataMember(Name = "real_name")]
        public string RealName { get { return realName; } set { if (realName != value) { realName = value; NotifyPropertyChanged("RealName"); } } }
        private string realName;

        [DataMember(Name = "email")]
        public string Email { get { return email; } set { if (email != value) { email = value; NotifyPropertyChanged("Email"); } } }
        private string email;

        [DataMember(Name = "skype")]
        public string Skype { get { return skype; } set { if (skype != value) { skype = value; NotifyPropertyChanged("Skype"); } } }
        private string skype;

        [DataMember(Name = "phone")]
        public string Phone { get { return phone; } set { if (phone != value) { phone = value; NotifyPropertyChanged("Phone"); } } }
        private string phone;

        [DataMember(Name = "image_24")]
        public Uri Image24x24 { get { return image24x24; } set { if (image24x24 != value) { image24x24 = value; NotifyPropertyChanged("Image24x24"); } } }
        private Uri image24x24;

        [DataMember(Name = "image_32")]
        public Uri Image32x32 { get { return image32x32; } set { if (image32x32 != value) { image32x32 = value; NotifyPropertyChanged("Image32x32"); } } }
        private Uri image32x32;

        [DataMember(Name = "image_48")]
        public Uri Image48x48 { get { return image48x48; } set { if (image48x48 != value) { image48x48 = value; NotifyPropertyChanged("Image48x48"); } } }
        private Uri image48x48;

        [DataMember(Name = "image_72")]
        public Uri Image72x72 { get { return image72x72; } set { if (image72x72 != value) { image72x72 = value; NotifyPropertyChanged("Image72x72"); } } }
        private Uri image72x72;

        [DataMember(Name = "image_192")]
        public Uri Image192x192 { get { return image192x192; } set { if (image192x192 != value) { image192x192 = value; NotifyPropertyChanged("Image192x192"); } } }
        private Uri image192x192;
    }
}
