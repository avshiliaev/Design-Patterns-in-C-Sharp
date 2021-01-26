using System;
using Behavioral.ChainOfResponsibility.Handlers;

namespace Behavioral.ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var requestHandler = new RequestHandler();
            var authenticationHandler = new ValidationHandler();
            var authorizationHandler = new AuthorizationHandler();

            requestHandler
                .AddMiddleware(authenticationHandler)
                .AddMiddleware(authorizationHandler);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Start from validation\n");
            App.RegisterHandlerPipeline(requestHandler);

            Console.WriteLine();

            Console.WriteLine("Skip validation\n");
            App.RegisterHandlerPipeline(authenticationHandler);
        }
    }
}