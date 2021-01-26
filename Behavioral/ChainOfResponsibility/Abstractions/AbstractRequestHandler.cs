using Behavioral.ChainOfResponsibility.Interfaces;

namespace Behavioral.ChainOfResponsibility.Abstractions
{
    // The default chaining behavior can be implemented inside a base handler
    // class.
    internal abstract class AbstractRequestHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public IRequestHandler AddMiddleware(IRequestHandler handler)
        {
            _nextHandler = handler;

            // Returning a handler from here will let us link handlers in a convenient way
            return handler;
        }

        public virtual IRequest Handle(IRequest request)
        {
            return _nextHandler?.Handle(request);
        }
    }
}