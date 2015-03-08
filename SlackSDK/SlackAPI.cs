using SlackSDK.API.RTM;
using SlackSDK.API.Web;

namespace SlackSDK
{
    public static class SlackAPI
    {
        public static SlackWebAPI WebAPI { get; } = new SlackWebAPI();
        public static SlackRealtimeAPI RealtimeAPI { get; } = new SlackRealtimeAPI();

        public static void Config(string token)
        {
            WebAPI.Config(token);
            RealtimeAPI.Config(token);
        }
    }
}
