namespace Structural.Decorator.Abstractions
{
    // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    internal abstract class SpecificNotifierDecorator : Notifier
    {
        protected Notifier _notifier;

        public SpecificNotifierDecorator(Notifier notifier)
        {
            _notifier = notifier;
        }

        public void SetComponent(Notifier notifier)
        {
            _notifier = notifier;
        }

        // The Decorator delegates all work to the wrapped component.
        public override string SendNotification()
        {
            if (_notifier != null)
                return _notifier.SendNotification();
            return string.Empty;
        }
    }
}