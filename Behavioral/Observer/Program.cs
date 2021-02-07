using Behavioral.Observer.Observers;
using Behavioral.Observer.Publishers;

namespace Behavioral.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code.
            var eventBus = new EventBus();

            var webSocket = new WebSocketInterface();
            var rabbitMq = new RabbitMqInterface();

            eventBus
                .Attach(webSocket)
                .Attach(rabbitMq);

            eventBus.UpdateState();
            eventBus.UpdateState();

            eventBus.Detach(rabbitMq);

            eventBus.UpdateState();
        }
    }
}