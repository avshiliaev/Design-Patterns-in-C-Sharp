using Structural.Bridge.Interfaces;

namespace Structural.Bridge.Implementations
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    internal class WindowsBackEndImplementation : IBackEndImplementation
    {
        public string OperationImplementation()
        {
            return "WindowsBackEnd: The result in Windows platform.\n";
        }
    }
}