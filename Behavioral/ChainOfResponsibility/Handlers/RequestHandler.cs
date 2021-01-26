using Behavioral.ChainOfResponsibility.Abstractions;
using Behavioral.ChainOfResponsibility.Interfaces;

namespace Behavioral.ChainOfResponsibility.Handlers
{
    internal class RequestHandler : AbstractRequestHandler
    {
        public override IRequest Handle(IRequest request)
        {
            if (!request.Expected)
                return null;
            return base.Handle(request);
        }
    }
}