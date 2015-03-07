﻿using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SlackSDK.Models
{
    public class Attachments : ObservableCollection<Attachment> { }

    [DataContract]
    public class Attachment : BaseModel
    {
    //{
    //    "fallback": "Required plain-text summary of the attachment.",

    //    "color": "#36a64f",

    //    "pretext": "Optional text that appears above the attachment block",

    //    "author_name": "Bobby Tables",
    //    "author_link": "http://flickr.com/bobby/",
    //    "author_icon": "http://flickr.com/icons/bobby.jpg",

    //    "title": "Slack API Documentation",
    //    "title_link": "https://api.slack.com/",

    //    "text": "Optional text that appears within the attachment",

    //    "fields": [
    //        {
    //            "title": "Priority",
    //            "value": "High",
    //            "short": false
    //        }
    //    ],

    //    "image_url": "http://my-website.com/path/to/image.jpg"
    //}
    }
}
