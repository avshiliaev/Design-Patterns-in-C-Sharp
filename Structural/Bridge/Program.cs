using System;
using Structural.Bridge.Abstractions;
using Structural.Bridge.Implementations;

namespace Structural.Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var clientApp = new ClientApp();

            FrontEndAbstraction frontEnd;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            frontEnd = new FrontEndAbstraction(new WindowsBackEndImplementation());
            clientApp.Run(frontEnd);

            Console.WriteLine();

            frontEnd = new ExtendedFrontEndAbstraction(new LinuxBackEndImplementation());
            clientApp.Run(frontEnd);
        }
    }
}