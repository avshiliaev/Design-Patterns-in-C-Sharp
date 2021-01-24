using Structural.Decorator.Abstractions;

namespace Structural.Decorator.Decorators
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    internal class EmailNotifierDecorator : SpecificNotifierDecorator
    {
        public EmailNotifierDecorator(Notifier comp) : base(comp)
        {
        }

        public override string SendNotification()
        {
            return $"Email ({base.SendNotification()})";
        }
    }
}