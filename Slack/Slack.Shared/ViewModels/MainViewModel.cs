using Slack.Common;
using SlackSDK.Models;

namespace Slack.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand SendMessageCommand { get; private set; }

        public Channels Channels { get { return channels; } set { channels = value; NotifyPropertyChanged("Channels"); } } //channels.Replace(value, this, "Channels"); } }
        private Channels channels = new Channels();
        
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