using Structural.Adapter.Interfaces;

namespace Structural.Adapter
{
    internal class Client
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }

        public void Call()
        {
            _target.GetRequest();
        }
    }
}