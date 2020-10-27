namespace Structural.Adapter.Legacy
{
    internal class LegacyClass
    {
        // The LegacyClass contains some useful behavior, but its interface is
        // incompatible with the existing client code. The LegacyClass needs some
        // adaptation before the client code can use it.
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}