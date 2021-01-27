namespace Behavioral.Observer.Interfaces
{
    public interface IEventBus
    {
        public int State { get; set; }

        // Attach an observer to the subject.
        IEventBus Attach(ISubscriber subscriber);

        // Detach an observer from the subject.
        IEventBus Detach(ISubscriber subscriber);

        // Notify all observers about an event.
        void Notify();
    }
}