using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The team_join event is sent to all connections 
    /// for a team when a new team member joins the team. 
    /// Clients can use this to update their local cache of team members.
    /// </summary>
    [DataContract]
    public class TeamJoinedSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "team_join";

        [DataMember(Name = "user")]
        public User User { get; protected set; }
    }
}
