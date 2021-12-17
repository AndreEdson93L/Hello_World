namespace PolymorphismInterface
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
