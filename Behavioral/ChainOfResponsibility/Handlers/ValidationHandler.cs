using Behavioral.ChainOfResponsibility.Abstractions;
using Behavioral.ChainOfResponsibility.Interfaces;

namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal class ValidationHandler : AbstractRequestHandler
    {
        public override IRequest Handle(IRequest request)
        {
            if (!request.Valid)
                return null;
            return base.Handle(request);
        }
    }
}