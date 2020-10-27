using Structural.Adapter.Interfaces;
using Structural.Adapter.Legacy;

namespace Structural.Adapter.Adapter
{
    internal class LegacyAdapter : ITarget
    {
        // The Adapter makes the LegacyClass's interface compatible with the Target's
        // interface.
        private readonly LegacyClass _legacy;

        public LegacyAdapter(LegacyClass legacy)
        {
            _legacy = legacy;
        }

        public string GetRequest()
        {
            return $"This is '{_legacy.GetSpecificRequest()}'";
        }
    }
}