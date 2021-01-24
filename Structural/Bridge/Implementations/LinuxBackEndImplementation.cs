using Structural.Bridge.Interfaces;

namespace Structural.Bridge.Implementations
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    internal class LinuxBackEndImplementation : IBackEndImplementation
    {
        public string OperationImplementation()
        {
            return "LinuxBackEnd: The result in Linux platform.\n";
        }
    }
}