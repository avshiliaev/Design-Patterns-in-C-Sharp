using System;
using Behavioral.Observer.Interfaces;

namespace Behavioral.Observer.Observers
{
    // Concrete Subscribers (Observers) react to the updates issued by the Publisher they had
    // been attached to.
    internal class RabbitMqInterface : ISubscriber
    {
        public void Update(IEventBus subject)
        {
            if (subject.State == 0 || subject.State >= 2)
                Console.WriteLine("Publish Event.");
        }
    }
}