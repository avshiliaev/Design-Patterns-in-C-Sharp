using System;
using Behavioral.ChainOfResponsibility.Abstractions;
using Behavioral.ChainOfResponsibility.Models;

namespace Behavioral.ChainOfResponsibility
{
    internal static class App
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void RegisterHandlerPipeline(AbstractRequestHandler handler)
        {
            var request = new Request
            {
                Expected = true,
                Valid = true,
                Authorized = false
            };

            var result = handler.Handle(request);

            if (result != null)
                Console.WriteLine("Success");
        }
    }
}