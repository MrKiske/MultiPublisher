using System;
using MultiPublisher.Interfaces;

namespace MultiPublisher.Class
{
    public class FacebookMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por facebook: {message}");
        }
    }
}
