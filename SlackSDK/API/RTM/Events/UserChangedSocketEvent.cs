using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The user_change event is sent to all connections 
    /// for a team when a team member updates their profile or data. 
    /// Clients can use this to update their local cache of team members.
    /// </summary>
    [DataContract]
    public class UserChangedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "user_change";

        [DataMember(Name = "user")]
        public User User { get; protected set; }
    }
}
