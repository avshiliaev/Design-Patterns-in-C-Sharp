namespace Behavioral.ChainOfResponsibility.Interfaces
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    public interface IRequestHandler
    {
        IRequestHandler AddMiddleware(IRequestHandler handler);

        IRequest Handle(IRequest request);
    }
}