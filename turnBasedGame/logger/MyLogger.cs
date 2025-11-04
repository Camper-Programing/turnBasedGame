using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace turnBasedGame.logger
{
    public sealed class MyLogger : Ilogger
    {
        private static readonly Lazy<MyLogger> lazy =
            new Lazy<MyLogger>(() => new MyLogger());
        private readonly List<TraceListener> listeners = new List<TraceListener>();
        private MyLogger() { }


        public static MyLogger Instance { get { return lazy.Value; } }

        public void addListener(TraceListener listener)
        {
            listeners.Add(listener);
        }
        public void removeListener(TraceListener listener)
        {
            listeners.Remove(listener);
        }

        public void Log(string message)
        {
            foreach (var listener in listeners)
            {
                listener.WriteLine(message);
            }
        }
    }
}
