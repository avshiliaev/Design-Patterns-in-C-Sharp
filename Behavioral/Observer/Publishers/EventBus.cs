using System;
using System.Collections.Generic;
using System.Threading;
using Behavioral.Observer.Interfaces;

namespace Behavioral.Observer.Publishers
{
    // The EventBus owns some important state and notifies subscribers when the
    // state changes.
    public class EventBus : IEventBus
    {
        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // The subscription management methods.
        public IEventBus Attach(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            return this;
        }

        public IEventBus Detach(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            return this;
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            foreach (var subscriber in _subscribers) subscriber.Update(this);
        }

        // Usually, the subscription logic is only a fraction of what a Publisher
        // can really do. Publishers commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public IEventBus UpdateState()
        {
            State = new Random().Next(0, 10);
            Thread.Sleep(15);
            Notify();

            return this;
        }
    }
}