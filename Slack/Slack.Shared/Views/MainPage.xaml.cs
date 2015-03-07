using Slack.Common;
using Slack.ViewModels;
using SlackSDK.API;
using System;
using System.Diagnostics;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Slack.Views
{
    public sealed partial class MainPage : Page
    {
        public NavigationHelper NavigationHelper { get { return this.navigationHelper; } }
        private NavigationHelper navigationHelper;

        public MainViewModel viewModel { get { return (MainViewModel)DataContext; } }

        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            //string code = await AuthAPI.Instance.AuthenticateAsync();
            //if (code == null) return;

            //var response = await AuthAPI.Instance.GetAccessToken(code);
            //if (response == null) return;

            string token = "xoxp-3916588710-3916588712-3914490519-c693ac";//response.AccessToken
            if (String.IsNullOrEmpty(token)) return;

            Debug.WriteLine("Token: " + token);
            var slackAPI = new SlackAPI(token);

            //var channels = await ChannelAPI.Instance.GetChannelList();
            //viewModel.Channels = channels;

            var response = await slackAPI.StartRTM();
            if (response == null) return;

            viewModel.Channels = response.Channels;

            Uri websocketUri = new Uri(response.URL);

            var socket = new MessageWebSocket();
            socket.MessageReceived += OnMessageReceived;

            await socket.ConnectAsync(websocketUri);
        }

        private void OnMessageReceived(MessageWebSocket sender, MessageWebSocketMessageReceivedEventArgs args)
        {
            DataReader dataReader = args.GetDataReader();
            string content = dataReader.ReadString(dataReader.UnconsumedBufferLength);

            Debug.WriteLine("OnMessageReceived: {0}", content);
        }

        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
