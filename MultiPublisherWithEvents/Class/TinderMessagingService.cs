using MultiPublisherWithEvents.BaseClass;
using System;

namespace MultiPublisher.Class
{
    public class TinderMessagingService : MessagingServiceBase
    {

        public TinderMessagingService() : base()
        {
            this.ServiceName = "Tinder";
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por tinder: {message}");
        }
    }
}
