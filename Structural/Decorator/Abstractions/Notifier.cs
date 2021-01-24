namespace Structural.Decorator.Abstractions
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    public abstract class Notifier
    {
        public abstract string SendNotification();
    }
}