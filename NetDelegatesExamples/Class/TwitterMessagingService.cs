using System;
using System.Collections.Generic;
using System.Text;

namespace NetDelegatesExamples.Class
{
    public class TwitterMessagingService
    {
        public event EventHandler<string> messageReceived;

        private readonly Func<string, bool> messageFilter;

        private readonly TwitterConfig twitterConfig; 
        public TwitterMessagingService(Func<string, bool> messageFilter, Action<TwitterConfig> configAction)
        {
            this.messageFilter = messageFilter;
            twitterConfig = new TwitterConfig();
            configAction(twitterConfig);
        }

        
    }
}
