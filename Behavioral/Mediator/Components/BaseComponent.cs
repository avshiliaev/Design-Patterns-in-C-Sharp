using Behavioral.Mediator.Interfaces;

namespace Behavioral.Mediator.Components
{
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    internal class BaseComponent
    {
        protected IMediator Mediator;

        protected BaseComponent(IMediator mediator = null)
        {
            Mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}