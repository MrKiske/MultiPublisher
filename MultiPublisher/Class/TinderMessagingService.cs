using MultiPublisher.Interfaces;
using System;

namespace MultiPublisher.Class
{
    public class TinderMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando mensaje por tinder: {message}");
        }
    }
}
