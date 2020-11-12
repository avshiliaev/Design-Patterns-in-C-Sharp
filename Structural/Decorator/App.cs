using System;
using Structural.Decorator.Abstractions;

namespace Structural.Decorator
{
    public class App
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void NotifyUser(Notifier component)
        {
            Console.WriteLine(component.SendNotification());
        }
    }
}