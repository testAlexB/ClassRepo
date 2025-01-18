namespace EventsProject
{
    public class Sender
    {

        public delegate void Message(string m);
        public event Message Notify;

        public Sender() 
        {

        }

        public void Send()
        {
            Notify.Invoke("Я Sender, отправил Вам сообщение!");
        }
    }
}
