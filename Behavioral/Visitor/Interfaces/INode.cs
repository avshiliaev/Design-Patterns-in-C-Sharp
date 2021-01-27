namespace Behavioral.Visitor.Interfaces
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface INode
    {
        void Accept(ISerializer visitor);
    }
}