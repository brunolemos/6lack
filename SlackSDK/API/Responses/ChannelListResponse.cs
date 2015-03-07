﻿using SlackSDK.Models;
using System.Runtime.Serialization;

namespace SlackSDK.API.Responses
{
    [DataContract]
    public class ChannelListResponse : StandardResponse
    {
        [DataMember(Name = "channels")]
        public Channels Channels { get; private set; }
    }
}