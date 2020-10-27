namespace Structural.Adapter.Interfaces
{
    public interface ITarget
    {
        // The Target defines the domain-specific interface used by the client code.
        string GetRequest();
    }
}