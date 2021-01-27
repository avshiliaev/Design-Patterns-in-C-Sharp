using Behavioral.Visitor.Components;

namespace Behavioral.Visitor.Interfaces
{
    // The Visitor Interface declares a set of visiting methods that correspond
    // to component classes. The signature of a visiting method allows the
    // visitor to identify the exact class of the component that it's dealing
    // with.
    public interface ISerializer
    {
        void SerializeRootNode(RootNode rootNode);

        void SerializeLeafNode(LeafNode leafNode);
    }
}