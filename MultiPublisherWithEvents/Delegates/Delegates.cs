using MultiPublisherWithEvents.Events;

namespace MultiPublisherWithEvents.Delegates
{
    public delegate void MessageReceivedEventHandler(object sender, MessageEventArgs e);
    public delegate void MessageEventHandler(object sender, MessageEventArgs e);
}
