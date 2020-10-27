using Structural.Adapter.Adapter;
using Structural.Adapter.Legacy;

namespace Structural.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var legacy = new LegacyClass();
            var target = new LegacyAdapter(legacy);

            var client = new Client(target);
            client.Call();
        }
    }
}