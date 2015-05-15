using Slack.Common;
using Slack.Utils;
using Slack.ViewModels;
using SlackSDK;
using System;
using System.Diagnostics;
using System.Linq;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Slack.Views
{
    public sealed partial class MainPage : Page
    {
        public NavigationHelper NavigationHelper { get { return this.navigationHelper; } }
        private NavigationHelper navigationHelper;

        public MainViewModel viewModel { get { return _viewModel; } }
        private static MainViewModel _viewModel = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            if (string.IsNullOrEmpty(AppSettings.Instance.AccessToken))
            {
                string code = await SlackAPI.WebAPI.AuthenticateAsync();
                if (String.IsNullOrEmpty(code)) return;

                AppSettings.Instance.AccessToken = await SlackAPI.WebAPI.GetAccessToken(code);
            }

            Debug.WriteLine("Token: '{0}'", AppSettings.Instance.AccessToken);
            if (string.IsNullOrEmpty(AppSettings.Instance.AccessToken)) return;

            SlackAPI.Config(AppSettings.Instance.AccessToken);

            //var channels = await ChannelAPI.Instance.GetChannelList();
            //viewModel.Channels = channels;

            var response = await SlackAPI.RealtimeAPI.Connect();
            if (response?.OK != true) return;

            SlackClient.Initialize(response);

            viewModel.SelectedTeam = SlackClient.Teams[0];
            viewModel.SelectedChannel = SlackClient.Teams[0].Channels[0];

            var messages = (await SlackAPI.WebAPI.GetChannelHistory(viewModel.SelectedTeam?.Channels[0]?.ID))?.Messages?.OrderBy(x => x.Timestamp);
            viewModel.Messages.Clear();
            foreach (var message in messages)
                viewModel.Messages.Add(message);

            SlackAPI.RealtimeAPI.MessageReceived += RealtimeAPI_MessageReceived;
        }

        private async void RealtimeAPI_MessageReceived(SlackSDK.API.RTM.Events.Messages.GenericMessageSocketEvent socketEvent)
        {
            var dispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                Debug.WriteLine("------> Mensagem recebida: {0}", socketEvent.Text);
                viewModel.Messages.Add(new SlackSDK.Models.Message(socketEvent));
            });
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

        private void MenuToggleButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
    }
}
