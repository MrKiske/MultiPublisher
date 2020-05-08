using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents.Events
{
    public class MessageEventArgs : EventArgs
    {

        public string message { get; private set; }

        public MessageEventArgs(string message)
        {
            this.message = message;
        }
    }
}