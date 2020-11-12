using Structural.Decorator.Abstractions;

namespace Structural.Decorator.Components
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    internal class ConcreteNotifier : Notifier
    {
        public override string SendNotification()
        {
            return "New Notification";
        }
    }
}