using System;
using Structural.Bridge.Abstractions;

namespace Structural.Bridge
{
    internal class ClientApp
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public void Run(FrontEndAbstraction frontEnd)
        {
            Console.Write(frontEnd.Operation());
        }
    }
}