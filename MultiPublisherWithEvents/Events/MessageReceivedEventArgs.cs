using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents.Events
{
    public class MessageReceivedEventArgs : EventArgs
    {

        public string message { get; private set; }


        protected MessageReceivedEventArgs(string message)
        {
            this.message = message;
        }
    }
}
