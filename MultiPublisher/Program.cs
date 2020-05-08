using MultiPublisher.Class;

namespace MultiPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessage = new TwitterMessagingService();
            var facebookMessage = new FacebookMessagingService();
            var tinderMessage = new TinderMessagingService();

            MessagingHelper.SayHelloAllServices(tinderMessage, facebookMessage, twitterMessage);
        }
    }
}
