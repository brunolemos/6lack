using SlackSDK.API.Responses;
using SlackSDK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SlackSDK.API
{
    public partial class SlackAPI
    {
        protected const string CHANNEL_ARCHIVE_METHOD = "channels.archive";
        protected const string CHANNEL_CREATE_METHOD = "channels.create";
        protected const string CHANNEL_HISTORY_METHOD = "channels.history";
        protected const string CHANNEL_INFO_METHOD = "channels.info";
        protected const string CHANNEL_INVITE_METHOD = "channels.invite";
        protected const string CHANNEL_JOIN_METHOD = "channels.join";
        protected const string CHANNEL_KICK_METHOD = "channels.kick";
        protected const string CHANNEL_LEAVE_METHOD = "channels.leave";
        protected const string CHANNEL_LIST_METHOD = "channels.list";
        protected const string CHANNEL_MARK_METHOD = "channels.mark";
        protected const string CHANNEL_RENAME_METHOD = "channels.rename";
        protected const string CHANNEL_SET_PURPOSE_METHOD = "channels.setPurpose";
        protected const string CHANNEL_SET_TOPIC_METHOD = "channels.setTopic";
        protected const string CHANNEL_UNARCHIVE_METHOD = "channels.unarchive";

        public async Task<bool> ArchiveChannel(string channelID)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_ARCHIVE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<StandardResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<Channel> CreateChannel(string channelName)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_CREATE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("name", channelName);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelResponse>(responseMessage);

            return response?.Channel;
        }

        public async Task<ChannelHistoryResponse> GetChannelHistory(string channelName, float? latest = null, float? oldest = null, bool? inclusive = null, ushort? count = null)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_HISTORY_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token",    Token);
            content.Add("channel",  channelName);

            //optional
            if(latest > 0)          content.Add("latest",       latest.ToString());
            if(oldest > 0)          content.Add("oldest",       oldest.ToString());
            if(inclusive != null)   content.Add("inclusive",    inclusive == true ? "1" : "0");
            if(count > 0)           content.Add("count",        count.ToString());

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            return await GetResultAs<ChannelHistoryResponse>(responseMessage);
        }

        public async Task<Channel> GetChannelInfo(string channelID)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_INFO_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelResponse>(responseMessage);

            return response?.Channel;
        }

        public async Task<Channel> InviteUserToChannel(string channelID, string userId)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_INVITE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("user", userId);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelResponse>(responseMessage);

            return response?.Channel;
        }

        public async Task<Channel> JoinChannel(string channelName)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_JOIN_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("name", channelName);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<JoinChannelResponse>(responseMessage);

            return response?.Channel;
        }

        public async Task<bool> KickUserFromChannel(string channelID, string userId)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_KICK_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("user", userId);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<bool> LeaveChannel(string channelID)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_LEAVE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<LeaveChannelResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<Channels> GetChannelList(bool? exclude_archived = null)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_LIST_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);

            //optional
            if(exclude_archived != null) content.Add("exclude_archived", exclude_archived == true ? "1" : "0");

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelListResponse>(responseMessage);

            return response?.Channels;
        }

        public async Task<bool> MarkChannel(string channelID, float ts)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_MARK_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("ts", ts.ToString());

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<StandardResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<Channel> RenameChannel(string channelID, string newName)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_MARK_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("name", newName);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<ChannelResponse>(responseMessage);

            return response?.Channel;
        }

        public async Task<bool> SetChannelPurpose(string channelID, string purpose)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_SET_PURPOSE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("purpose", purpose);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<PurposeChannelResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<bool> SetChannelTopic(string channelID, string topic)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_SET_TOPIC_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);
            content.Add("topic", topic);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<TopicChannelResponse>(responseMessage);

            return response?.OK == true;
        }

        public async Task<bool> UnarchiveChannel(string channelID)
        {
            var uri = new Uri(API_BASE_URI, CHANNEL_UNARCHIVE_METHOD);

            var content = new Dictionary<string, string>();
            content.Add("token", Token);
            content.Add("channel", channelID);

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, new HttpFormUrlEncodedContent(content));
            var response = await GetResultAs<StandardResponse>(responseMessage);

            return response?.OK == true;
        }
    }
}