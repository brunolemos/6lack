using SlackSDK.API.Web;
using SlackSDK.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Security.Authentication.Web;
using Windows.Web.Http;

namespace SlackSDK.API.Web
{
    public partial class SlackWebAPI : BaseAPI
    {
        protected const string AUTHORIZE_URL_FORMAT = "https://slack.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}&state={3}";
        protected const string AUTH_ACCESS_METHOD = "oauth.access";

        string state = Guid.NewGuid().ToString();
        string code;

        [Obsolete("Don't use this in production! This is for local test purposes only. Be careful with your secret key.")]
        public async Task<string> GetAccessToken(string code)
        {
            if (string.IsNullOrEmpty(code)) return null;

            var uri = new Uri(API_BASE_URI, AUTH_ACCESS_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("client_id", CLIENT_ID);
            content.Add("client_secret", CLIENT_SECRET);
            content.Add("code", code);
            content.Add("redirect_uri", REDIRECT_URL);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<AuthAccessResponse>(responseMessage);

            return response?.AccessToken;
        }

        public async Task<string> AuthenticateAsync()
        {
            string scope = "client";
            string authURL = String.Format(AUTHORIZE_URL_FORMAT, CLIENT_ID, Uri.EscapeDataString(REDIRECT_URL), scope, state);
            Debug.WriteLine("Navigating to: " + authURL);

            Uri StartUri = new Uri(authURL);
            Uri EndUri = new Uri(REDIRECT_URL);

            try
            {
                WebAuthenticationResult WebAuthenticationResult =
                    await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, StartUri, EndUri);

                switch (WebAuthenticationResult.ResponseStatus)
                {
                    case WebAuthenticationStatus.Success:
                        Debug.WriteLine("Response: {0}", WebAuthenticationResult.ResponseData);
                        return GetCodeFromAuthenticationResult(WebAuthenticationResult);

                    case WebAuthenticationStatus.ErrorHttp:
                        Debug.WriteLine("HTTP Error returned by AuthenticateAsync(): {0}", WebAuthenticationResult.ResponseErrorDetail.ToString());
                        return null;

                    default:
                        Debug.WriteLine("Error returned by AuthenticateAsync(): {0}", WebAuthenticationResult.ResponseStatus.ToString());
                        return null;
                }
            }

            // Bad Parameter, SSL/TLS Errors and Network Unavailable errors are to be handled here.
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return null;
            }
        }

        private string GetCodeFromAuthenticationResult(WebAuthenticationResult result)
        {
            if (result.ResponseStatus != WebAuthenticationStatus.Success) return null;

            Uri resultAsUri = new Uri(result.ResponseData);
            WwwFormUrlDecoder decoder = new WwwFormUrlDecoder(resultAsUri.Query);
            Dictionary<string, string> queryParams = decoder.ToDictionary(x => x.Name, x => x.Value);

            if (!queryParams.ContainsKey("code")) return null;
            code = queryParams["code"];

            Debug.WriteLine("Received code: {0}", code);
            return code;
        }
    }
}
