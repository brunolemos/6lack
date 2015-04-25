using SlackSDK.Models;
using SlackSDK.Responses;
using System.Linq;

namespace SlackSDK
{
    public static class SlackClient
    {
        public static Teams Teams { get; } = new Teams();
        public static Users Users { get; private set; } = new Users();

        public static void Initialize(RealtimeStartResponse initialData)
        {
            initialData.Team.Members = initialData.Users;
            initialData.Team.Channels = initialData.Channels;

            AddOrReplaceTeam(initialData.Team);
            Users = initialData.Users ?? Users;
        }

        public static void AddOrReplaceTeam(Team team)
        {
            if (team == null) return;
            Team teamAlreadyAdded = Teams.Where(x => x.ID == team.ID).FirstOrDefault();

            //add
            if (teamAlreadyAdded == null) 
                Teams.Add(team);

            //replace
            else
            {
                int index = Teams.IndexOf(teamAlreadyAdded);
                Teams[index] = team;
            }
        }
    }
}
