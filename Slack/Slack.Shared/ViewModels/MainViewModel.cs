using Slack.Common;
using SlackSDK;
using SlackSDK.Models;

namespace Slack.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand SendMessageCommand { get; private set; }

        public static Teams Teams { get { return SlackClient.Teams; } }
        public static Users Users { get { return SlackClient.Users; } }

        public Messages Messages { get { return messages; } set { messages = value; NotifyPropertyChanged("Messages"); } }
        private Messages messages = new Messages();

        public Team SelectedTeam { get { return selectedTeam; } set { selectedTeam = value; NotifyPropertyChanged("SelectedTeam"); } }
        private Team selectedTeam;

        public Channel SelectedChannel { get { return selectedChannel; } set { selectedChannel = value; NotifyPropertyChanged("SelectedChannel"); } }
        private Channel selectedChannel;

        public MainViewModel()
        {
            SendMessageCommand = new RelayCommand(SendMessage);

            //AppData.ChannelsChanged += (s, e) => NotifyPropertyChanged("Channels");
        }

#region COMMANDS_ACTIONS

        private void SendMessage()
        {
        }

#endregion
    }
}