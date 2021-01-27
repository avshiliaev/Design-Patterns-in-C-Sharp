using Behavioral.Visitor.Interfaces;

namespace Behavioral.Visitor.Components
{
    // Each Concrete Component must implement the `Accept` method in such a way
    // that it calls the visitor's method corresponding to the component's
    // class.
    public class RootNode : INode
    {
        // Note that we're calling `SerializeRootNode`, which matches the
        // current class name. This way we let the visitor know the class of the
        // component it works with.
        public void Accept(ISerializer visitor)
        {
            visitor.SerializeRootNode(this);
        }

        // Concrete Components may have special methods that don't exist in
        // their base class or interface. The Visitor is still able to use these
        // methods since it's aware of the component's concrete class.
        public string RootNodeSerialization()
        {
            return "RootNode";
        }
    }
}