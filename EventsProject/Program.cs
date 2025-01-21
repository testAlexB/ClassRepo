using System;

namespace EventsProject
{
    class Program
    {
        static void Main()
        {
            Sender sender = new Sender();

            ReceiverConsole receiverConsole = new ReceiverConsole();
            receiverConsole.Connect(sender);

            ReceiverFile receiverFile = new ReceiverFile();
            receiverFile.Connect(sender);

            sender.Send();

            Console.ReadKey();
        }
    }
}
