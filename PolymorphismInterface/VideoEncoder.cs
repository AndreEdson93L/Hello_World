using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in _notificationChannels)
                channel.Send(new Message()); //Send method == polimorphic behaviour
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
