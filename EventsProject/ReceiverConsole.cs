using System;

namespace EventsProject
{
    public class ReceiverConsole
    {
        public void Connect(Sender s)
        {
            /// подписываемся на события объекта s
            s.Notify += ShowMessageToConsole;
        }

        private void ShowMessageToConsole(string m)
        {
            Console.WriteLine($"{this.GetHashCode()} object reaction by message: {m}");
        }
    }
}
