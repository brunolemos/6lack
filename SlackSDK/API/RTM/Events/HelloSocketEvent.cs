using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The hello event is sent when a connection is opened to the message server.
    /// This allows a client to confirm the connection has been correctly opened.
    /// </summary>
    [DataContract]
    public class HelloSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "hello";
    }
}
