using SlackSDK.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SlackSDK.API.Web
{
    public partial class SlackWebAPI : BaseAPI
    {
        protected const string RTM_START_METHOD = "rtm.start";

        internal async Task<RealtimeStartResponse> StartRTM()
        {
            var uri = new Uri(API_BASE_URI, RTM_START_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            return await GetResultAs<RealtimeStartResponse>(responseMessage);
        }
    }
}