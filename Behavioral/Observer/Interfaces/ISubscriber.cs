namespace Behavioral.Observer.Interfaces
{
    public interface ISubscriber
    {
        // Receive update from eventBus
        void Update(IEventBus eventBus);
    }
}