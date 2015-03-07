using SlackSDK.Common;
using SlackSDK.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SlackSDK
{
    public static class Extensions
    {
        //ENUM CONVERTER
        public static string ToAPIString(this UserPresence x) { return x.ToString().ToLower(); }
        public static string ToAPIString(this MessageMarkdown x) { return x.ToString().ToLower(); }
        public static string ToAPIString(this MessageParse x) { return x.ToString().ToLower(); }

        //public static void Replace<T>(this ICollection<T> collection, ICollection<T> newContent)
        //{
        //    collection.Clear();
        //    if (newContent?.Count <= 0) return;

        //    foreach (var item in newContent)
        //        collection.Add(item);
        //}


        //public static void Replace<T>(this ICollection<T> collection, ICollection<T> newContent, Notifiable sender = null, string ProperyNameToNotify = "")
        //{
        //    collection.Replace(newContent);

        //    if (sender != null && !string.IsNullOrEmpty(ProperyNameToNotify)) sender.NotifyPropertyChanged(ProperyNameToNotify);
        //}
    }
}
