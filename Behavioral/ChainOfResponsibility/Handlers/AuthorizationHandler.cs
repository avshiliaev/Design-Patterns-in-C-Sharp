using Behavioral.ChainOfResponsibility.Abstractions;
using Behavioral.ChainOfResponsibility.Interfaces;

namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal class AuthorizationHandler : AbstractRequestHandler
    {
        public override IRequest Handle(IRequest request)
        {
            if (!request.Authorized)
                return null;
            return base.Handle(request);
        }
    }
}