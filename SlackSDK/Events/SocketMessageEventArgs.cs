using System;

namespace SlackSDK.Events
{
    public class SocketMessageEventArgs<T> : EventArgs
    {
        public T SocketEvent { get; private set; }

        public SocketMessageEventArgs(T socketEvent)
        {
            SocketEvent = socketEvent;
        }
    }
}
