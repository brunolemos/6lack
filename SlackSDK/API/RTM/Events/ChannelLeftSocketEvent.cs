﻿using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events
{
    /// <summary>
    /// The channel_left event is sent to all connections 
    /// for a user when that user leaves a channel. 
    /// Clients should respond to this message by closing the channel - 
    /// this means that when a channel is left from client A, 
    /// it will automatically be closed in client B.
    /// 
    /// In addition to this message, all existing members of the channel 
    /// will recieve a channel_leave message event.
    /// </summary>
    [DataContract]
    public class ChannelLeftSocketEvent : BaseSocketEvent
    {
        public const string TYPE = "channel_left";

        [DataMember(Name = "channel")]
        public Channel Channel { get; protected set; }
    }
}
