using MultiPublisher.Interfaces;
using MultiPublisherWithEvents.BaseClass;
using MultiPublisherWithEvents.Delegates;
using System;

namespace MultiPublisher.Class
{
    public class TwitterMessagingService : MessagingServiceBase
    {
        public TwitterMessagingService() : base()
        {
            this.ServiceName = "Twitter";
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por twitter: {message}");
        }

    }
}