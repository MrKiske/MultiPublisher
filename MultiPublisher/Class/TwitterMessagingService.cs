using MultiPublisher.Interfaces;
using System;

namespace MultiPublisher.Class
{
    public class TwitterMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por twitter: {message}");
        }
    }
}
