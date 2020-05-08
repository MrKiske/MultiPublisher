using MultiPublisher.Interfaces;

namespace MultiPublisher
{
    public static class MessagingHelper
    {
        public static void SayHelloAllServices(params IMessagingService[] services)
        {
            foreach (var service in services)
            {
                service.SendMessage("Hello World");
            }

        }
    }
}
