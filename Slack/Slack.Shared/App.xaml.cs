using Slack.Views;
using System;
using System.Linq;
using System.Reflection;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Slack
{
    public sealed partial class App : Application
    {
#if WINDOWS_PHONE_APP
        private TransitionCollection transitions;
#endif
        
        public App()
        {
            this.InitializeComponent();
            this.Suspending += this.OnSuspending;
        }
        
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                // TODO: change this value to a cache size that is appropriate for your application
                rootFrame.CacheSize = 1;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
#if WINDOWS_PHONE_APP
                // Removes the turnstile navigation for startup.
                if (rootFrame.ContentTransitions != null)
                {
                    this.transitions = new TransitionCollection();
                    foreach (var c in rootFrame.ContentTransitions)
                    {
                        this.transitions.Add(c);
                    }
                }

                rootFrame.ContentTransitions = null;
                rootFrame.Navigated += this.RootFrame_FirstNavigated;
#endif

                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(MainPage), e.Arguments))
                {
                    throw new Exception("Failed to create initial page");
                }
            }

            //window chrome
            ChangeWindowChromeAppearence(false);

            // Ensure the current window is active
            Window.Current.Activate();
        }

#if WINDOWS_PHONE_APP
        private void RootFrame_FirstNavigated(object sender, NavigationEventArgs e)
        {
            var rootFrame = sender as Frame;
            rootFrame.ContentTransitions = this.transitions ?? new TransitionCollection() { new NavigationThemeTransition() };
            rootFrame.Navigated -= this.RootFrame_FirstNavigated;
        }
#endif
        
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();

            // TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        private void ChangeWindowChromeAppearence(bool isVisible)
        {
            try
            {
                var v = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
                var allProperties = v.GetType().GetRuntimeProperties();
                var titleBar = allProperties.FirstOrDefault(x => x.Name == "TitleBar");
                if (titleBar == null) return;

                dynamic titleBarInst = titleBar.GetMethod.Invoke(v, null);
                titleBarInst.ExtendViewIntoTitleBar = !isVisible;

                titleBarInst.BackgroundColor = isVisible ? Color.FromArgb(0xff, 0xee, 0xee, 0xee) : Colors.Transparent;
                titleBarInst.ForegroundColor = Colors.Black;

                titleBarInst.ButtonBackgroundColor = isVisible ? Color.FromArgb(0xff, 0xee, 0xee, 0xee) : Colors.Transparent;
                titleBarInst.ButtonForegroundColor = Colors.Black;

                titleBarInst.ButtonHoverBackgroundColor = Color.FromArgb(0xff, 0x51, 0x35, 0x4b);
                titleBarInst.ButtonHoverForegroundColor = Colors.White;

                titleBarInst.ButtonPressedBackgroundColor = Color.FromArgb(0xff, 0x41, 0x2f, 0x3c);
                titleBarInst.ButtonPressedForegroundColor = Colors.White;
            }
            catch (Exception)
            {
            }
        }
    }
}