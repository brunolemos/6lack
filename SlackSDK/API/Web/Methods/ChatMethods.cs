using Newtonsoft.Json;
using SlackSDK.Responses;
using SlackSDK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SlackSDK.API.Web
{
    public partial class SlackWebAPI : BaseAPI
    {
        protected const string CHAT_DELETE_METHOD = "chat.delete";
        protected const string CHAT_POST_MESSAGE_METHOD = "chat.postMessage";
        protected const string CHAT_UPDATE_METHOD = "channels.chat.update";

        public async Task<bool> DeleteMessage(string messageTimestamp, string channelID)
        {
            var uri = new Uri(API_BASE_URI, CHAT_DELETE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("ts", messageTimestamp.ToString());
            content.Add("channel", channelID);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<DeleteMessageResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<PostMessageResponse> PostMessage(string channelID, string text, MessageParse? parse = null, 
            bool? linkNames = null, Attachments attachments = null, 
            bool? unfurlLinks = null, bool? unfurlMedia = null)
        {
            var uri = new Uri(API_BASE_URI, CHAT_POST_MESSAGE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("text", text);
            content.Add("as_user", "true");

            //optional
            if (parse != null) content.Add("parse", parse?.ToAPIString());
            if (linkNames != null) content.Add("link_names", linkNames == true ? "1" : "0");
            if (attachments?.Count > 0) content.Add("attachments", JsonConvert.SerializeObject(attachments));
            if (unfurlLinks != null) content.Add("unfurl_links", unfurlLinks == true ? "true" : "false");
            if (unfurlMedia != null) content.Add("unfurl_media", unfurlMedia == true ? "true" : "false");

            //bots only
            //content.Add("username", username);
            //content.Add("icon_url", iconURL);
            //content.Add("icon_emoji", iconEmoji);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            return await GetResultAs<PostMessageResponse>(responseMessage);
        }

        public async Task<UpdateMessageResponse> UpdateMessage(string messageTimestamp, string channelID, string newText)
        {
            var uri = new Uri(API_BASE_URI, CHAT_UPDATE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("ts", messageTimestamp.ToString());
            content.Add("channel", channelID);
            content.Add("text", newText);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            return await GetResultAs<UpdateMessageResponse>(responseMessage);
        }
    }
}