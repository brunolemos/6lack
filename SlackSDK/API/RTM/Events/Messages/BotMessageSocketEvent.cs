using System.Runtime.Serialization;

namespace SlackSDK.API.RTM.Events.Messages
{
    /// <summary>
    /// A bot_message is sent when a message is sent 
    /// to a channel by an integration "bot". 
    /// It is like a normal user message, except it has no associated user.
    /// 
    /// The bot_id tells you which bot sent this message, 
    /// the username and icon to use can be looked up using this. 
    /// Some bot_messages also include username and/or icons properties.
    /// If present these override the default username or icon for this bot.
    /// </summary>
    [DataContract]
    public class BotMessageSocketEvent : MessageSocketEvent
    {
        public const string SUBTYPE = "bot_message";
        
        [DataMember(Name = "text")]
        public string Text { get; protected set; }

        [DataMember(Name = "bot_id")]
        public string BotID { get; protected set; }

        [DataMember(Name = "username")]
        public string Username { get; protected set; }

        //"icons": {}
    }
}
