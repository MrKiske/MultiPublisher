using System;
using MultiPublisherWithEvents.BaseClass;

namespace MultiPublisher.Class
{
    public class FacebookMessagingService : MessagingServiceBase
    {

        public FacebookMessagingService(): base()
        {
            this.ServiceName = "Facebook";
        }

        public override void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
