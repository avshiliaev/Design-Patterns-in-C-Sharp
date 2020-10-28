using Structural.Bridge.Interfaces;

namespace Structural.Bridge.Abstractions
{
    // The Abstraction defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    internal class FrontEndAbstraction
    {
        protected IBackEndImplementation _implementation;

        public FrontEndAbstraction(IBackEndImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                   _implementation.OperationImplementation();
        }
    }
}