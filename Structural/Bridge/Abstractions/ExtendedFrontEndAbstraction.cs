using Structural.Bridge.Interfaces;

namespace Structural.Bridge.Abstractions
{
    // You can extend the Abstraction without changing the Implementation
    // classes.
    internal class ExtendedFrontEndAbstraction : FrontEndAbstraction
    {
        public ExtendedFrontEndAbstraction(IBackEndImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                   _implementation.OperationImplementation();
        }
    }
}