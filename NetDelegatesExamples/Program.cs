using NetDelegatesExamples.Class;
using System;
using System.Security.Cryptography.X509Certificates;

namespace NetDelegatesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessage = new TwitterMessagingService(
                (msg)=> !msg.Contains("facebook"), 
                (config)=> 
                { 
                    config.UserName = "abc"; 
                    config.Password = "$$$$"; 
                });
            twitterMessage.messageReceived += (sender, msg) => Console.WriteLine(msg);

             
        }
    }
}
