﻿using System;

namespace EventsProject
{
    public class ReceiverConsole
    {
        public void Connect(Sender s)
        {
            /// подписываемся на события объекта s
            s.Notify += S_Notify;
        }

        private void S_Notify(string m)
        {
            Console.WriteLine($"{this.GetHashCode()} object reaction by message: {m}");
        }
    }
}
