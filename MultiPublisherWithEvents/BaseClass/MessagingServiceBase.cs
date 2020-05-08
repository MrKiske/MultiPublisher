using MultiPublisher.Interfaces;
using MultiPublisherWithEvents.Delegates;
using MultiPublisherWithEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MultiPublisherWithEvents.BaseClass
{
    public abstract class MessagingServiceBase : IMessagingService
    {
        private readonly Timer messageTimer;
        private readonly Random random;

        public string ServiceName { get; protected set; }

        public event MessageReceivedEventHandler MessagingReceived;

        public MessagingServiceBase()
        {
            random = new Random(DateTime.Now.Millisecond);
            messageTimer = new Timer { Interval = random.Next(2000, 5001) };
            messageTimer.Elapsed += this.MessagesTimer_Elapsed;
            messageTimer.Start();
        }

        public void Dispose() 
        {
            messageTimer.Elapsed -= this.MessagesTimer_Elapsed;
            messageTimer.Stop();
            messageTimer.Dispose();
        }

        public abstract void SendMessage(string message);
      
        private void MessagesTimer_Elapsed(object sender, ElapsedEventArgs e )
        {
            this.MessagingReceived?.Invoke(this, new MessageEventArgs($"Message received from {this.ServiceName}."));
            this.messageTimer.Interval = random.Next(2000, 5001);
        }
    }
}
