using MultiPublisherWithEvents.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher.Interfaces
{
    public interface IMessagingService
    {
        event MessageReceivedEventHandler MessagingReceived;

        void SendMessage(string message);

    }
}
