using Slack.Common;

namespace Slack.Utils
{
    public class AppSettings : AppSettingsBase
    {
        public static readonly AppSettings Instance = new AppSettings();

        public override uint Version { get { return VERSION; } }
        private const uint VERSION = 1;

        private const string ACCESS_TOKEN_KEY = "ACCESS_TOKEN";
        private const string ACCESS_TOKEN_DEFAULT = "";

        private AppSettings()
        {
        }

        public override void Up()
        {
        }

        public override void Down()
        {
        }

        public string AccessToken
        {
            get { return GetValueOrDefault(ACCESS_TOKEN_KEY, ACCESS_TOKEN_DEFAULT); }
            set { SetValue<string>(ACCESS_TOKEN_KEY, value); }
        }
    }
}