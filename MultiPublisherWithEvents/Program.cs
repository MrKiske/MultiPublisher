using MultiPublisher.Class;
using MultiPublisherWithEvents.Events;
using System;
using System.Runtime.CompilerServices;

namespace MultiPublisherWithEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessage = new TwitterMessagingService();
            var facebookMessage = new FacebookMessagingService();
            var tinderMessage = new TinderMessagingService();

            twitterMessage.MessagingReceived += MessagingService_MessageReceived;
            facebookMessage.MessagingReceived += MessagingService_MessageReceived;
            tinderMessage.MessagingReceived += MessagingService_MessageReceived;

            Console.ReadLine();

            twitterMessage.MessagingReceived -= MessagingService_MessageReceived;
            facebookMessage.MessagingReceived -= MessagingService_MessageReceived;
            tinderMessage.MessagingReceived -= MessagingService_MessageReceived;

            twitterMessage.Dispose();
            facebookMessage.Dispose();
            tinderMessage.Dispose();
        }


        private static void MessagingService_MessageReceived(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.message);
        }
    }
}
