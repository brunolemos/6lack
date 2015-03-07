using Newtonsoft.Json;
using SlackSDK.API.Responses;
using SlackSDK.Utils;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Web.Http;

namespace SlackSDK.API
{
    public partial class SlackAPI
    {
        protected HttpClient httpClient = new HttpClient();
        protected string Token { get; set; }

        protected static Uri API_BASE_URI = new Uri("https://slack.com/api/", UriKind.Absolute);
        protected const string REDIRECT_URL = Constants.REDIRECT_URL;
        protected const string CLIENT_ID = Constants.CLIENT_ID;
        protected const string CLIENT_SECRET = Constants.CLIENT_SECRET;

        public SlackAPI(string token)
        {
            Config(token);
        }

        public void Config(string token)
        {
            Token = token;
        }

        protected async Task<T> GetResultAs<T>(HttpResponseMessage responseMessage, bool showErrorDialog = true) where T : StandardResponse
        {
            string response = await responseMessage.Content.ReadAsStringAsync();
            Debug.WriteLine("Response: " + response);

            if (!responseMessage.IsSuccessStatusCode)
            {
                if (!String.IsNullOrEmpty(responseMessage.ReasonPhrase) && responseMessage.ReasonPhrase.Substring(0, 9) != "code: 10,")
                    await new MessageDialog(responseMessage.ReasonPhrase, "Oops!").ShowAsync();

                return null;
            }

            try
            {
                var result = JsonConvert.DeserializeObject<T>(response);
                if (result?.OK == true) return result;

                //HandleCallError(result.Error);
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //protected void HandleCallError(string errorID)
        //{
        //    if (string.IsNullOrEmpty(errorID)) return;

        //    switch (errorID)
        //    {
        //        case AccountInactiveException.ID:
        //            break;

        //        default:
        //            break;
        //    }

        //}
    }
}
