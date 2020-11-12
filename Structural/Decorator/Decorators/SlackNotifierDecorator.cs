using Structural.Decorator.Abstractions;

namespace Structural.Decorator.Decorators
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    internal class SlackNotifierDecorator : SpecificNotifierDecorator
    {
        public SlackNotifierDecorator(Notifier notifier) : base(notifier)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string SendNotification()
        {
            return $"Slack ({base.SendNotification()})";
        }
    }
}