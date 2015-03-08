namespace SlackSDK
{
    public static class Extensions
    {
        //ENUM CONVERTER
        public static string ToAPIString(this UserPresence x) { return x.ToString().ToLower(); }
        public static string ToAPIString(this MessageMarkdown x) { return x.ToString().ToLower(); }
        public static string ToAPIString(this MessageParse x) { return x.ToString().ToLower(); }
    }
}
