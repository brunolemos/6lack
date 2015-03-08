using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SlackSDK.API.RTM.Events;
using SlackSDK.Responses;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace SlackSDK.API.RTM
{
    public partial class SlackRealtimeAPI : BaseAPI
    {
        private MessageWebSocket socket;

        public delegate void SocketMessageEventHandler<T>(T socketEvent);
        public event SocketMessageEventHandler<ChannelArchivedSocketEvent> ChannelArchived;
        public event SocketMessageEventHandler<ChannelCreatedSocketEvent> ChannelCreated;
        public event SocketMessageEventHandler<ChannelDeletedSocketEvent> ChannelDeleted;
        public event SocketMessageEventHandler<ChannelHistoryChangedSocketEvent> ChannelHistoryChanged;
        public event SocketMessageEventHandler<ChannelJoinedSocketEvent> ChannelJoined;
        public event SocketMessageEventHandler<ChannelLeftSocketEvent> ChannelLeft;
        public event SocketMessageEventHandler<ChannelMarkedSocketEvent> ChannelMarked;
        public event SocketMessageEventHandler<ChannelRenamedSocketEvent> ChannelRenamed;
        public event SocketMessageEventHandler<ChannelUnarchivedSocketEvent> ChannelUnarchived;
        public event SocketMessageEventHandler<HelloSocketEvent> HelloReceived;
        public event SocketMessageEventHandler<ManualPresenceChangedSocketEvent> ManualPresenceChanged;
        public event SocketMessageEventHandler<PrefChangedSocketEvent> PrefChanged;
        public event SocketMessageEventHandler<PresenceChangedSocketEvent> PresenceChanged;
        public event SocketMessageEventHandler<TeamJoinedSocketEvent> TeamJoined;
        public event SocketMessageEventHandler<UserChangedSocketEvent> UserChanged;

        internal SlackRealtimeAPI() { }

        public async Task<RealtimeStartResponse> Connect()
        {
            var response = await SlackAPI.WebAPI.StartRTM();
            if (response == null) return null;

            Uri websocketUri = new Uri(response.URL);
            if (websocketUri == null) return null;

            try
            {
                socket = new MessageWebSocket();
                socket.MessageReceived += OnMessageReceived;

                await socket.ConnectAsync(websocketUri);
                return response;
            }
            catch (Exception)
            {
                Disconnect();
                return null;
            }
        }

        public void Disconnect()
        {
            if (socket == null) return;

            //unhandle
            socket.MessageReceived -= OnMessageReceived;

            //close connection
            socket.Close(1000, string.Empty);
            socket.Dispose();
        }

        private void OnMessageReceived(MessageWebSocket sender, MessageWebSocketMessageReceivedEventArgs args)
        {
            DataReader dataReader = args.GetDataReader();

            string content = dataReader.ReadString(dataReader.UnconsumedBufferLength);
            Debug.WriteLine("OnMessageReceived: {0}", content);

            HandleSocketMessage(content);
        }

        private void HandleSocketMessage(string json)
        {
            string type = JObject.Parse(json)?["type"]?.ToString();
            if (string.IsNullOrEmpty(type)) return;

            switch (type)
            {
                case ChannelArchivedSocketEvent.TYPE:       DispatchSocketEventHandler(ChannelArchived, json); break;
                case ChannelCreatedSocketEvent.TYPE:        DispatchSocketEventHandler(ChannelCreated, json); break;
                case ChannelDeletedSocketEvent.TYPE:        DispatchSocketEventHandler(ChannelDeleted, json); break;
                case ChannelHistoryChangedSocketEvent.TYPE: DispatchSocketEventHandler(ChannelHistoryChanged, json); break;
                case ChannelJoinedSocketEvent.TYPE:         DispatchSocketEventHandler(ChannelJoined, json); break;
                case ChannelLeftSocketEvent.TYPE:           DispatchSocketEventHandler(ChannelLeft, json); break;
                case ChannelMarkedSocketEvent.TYPE:         DispatchSocketEventHandler(ChannelMarked, json); break;
                case ChannelRenamedSocketEvent.TYPE:        DispatchSocketEventHandler(ChannelRenamed, json); break;
                case ChannelUnarchivedSocketEvent.TYPE:     DispatchSocketEventHandler(ChannelUnarchived, json); break;
                case HelloSocketEvent.TYPE:                 DispatchSocketEventHandler(HelloReceived, json); break;
                case ManualPresenceChangedSocketEvent.TYPE: DispatchSocketEventHandler(ManualPresenceChanged, json); break;
                case PrefChangedSocketEvent.TYPE:           DispatchSocketEventHandler(PrefChanged, json); break;
                case PresenceChangedSocketEvent.TYPE:       DispatchSocketEventHandler(PresenceChanged, json); break;
                case TeamJoinedSocketEvent.TYPE:            DispatchSocketEventHandler(TeamJoined, json); break;
                case UserChangedSocketEvent.TYPE:           DispatchSocketEventHandler(UserChanged, json); break;

                case MessageSocketEvent.TYPE:
                    //string subtype = JObject.Parse(json)?["subtype"]?.ToString() ?? "null";
                    //if (String.IsNullOrEmpty(subtype)) return;

                    //switch (subtype)
                    //{
                    //    case HelloSocketEvent.TYPE: DispatchSocketEventHandler(HelloSocketEventReceived, json); break;
                    //}
                    break;
            }
        }

        private void DispatchSocketEventHandler<T>(SocketMessageEventHandler<T> handler, string json)
        {
            var socketEvent = JsonConvert.DeserializeObject<T>(json);
            if (socketEvent == null) return;

            if (handler != null) handler(socketEvent);
        }
    }
}
