using System.IO;

namespace EventsProject
{
    public class ReceiverFile
    {
        public void Connect(Sender s)
        {
            s.Notify += S_Notify;
        }

        private void S_Notify(string m)
        {
            File.WriteAllText(Path.Combine("D:\\Бойков\\P30", "ReceiverFile.txt"), m);
        }
    }
}
