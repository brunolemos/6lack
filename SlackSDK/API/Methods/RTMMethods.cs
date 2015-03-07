using SlackSDK.API.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SlackSDK.API
{
    public partial class SlackAPI
    {
        protected const string RTM_START_METHOD = "rtm.start";

        public async Task<RealtimeStartResponse> StartRTM()
        {
            var uri = new Uri(API_BASE_URI, RTM_START_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            return await GetResultAs<RealtimeStartResponse>(responseMessage);
        }
    }
}