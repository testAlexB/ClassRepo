using System.IO;

namespace EventsProject
{
    public class ReceiverFile
    {
        public void Connect(Sender s)
        {
            s.Notify += SaveMessageToFile;
        }

        private void SaveMessageToFile(string m)
        {
            File.WriteAllText(Path.Combine("D:\\Бойков\\P30", "ReceiverFile.txt"), m);
        }
    }
}
