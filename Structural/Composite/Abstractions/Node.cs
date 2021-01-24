using System;

namespace Structural.Composite.Abstractions
{
    // The base Component class declares common operations for both simple and
    // complex objects of a composition.
    internal abstract class Node
    {
        // The base Component may implement some default behavior or leave it to
        // concrete classes (by declaring the method containing the behavior as
        // "abstract").
        public abstract double GetWaterConsumption();

        // In some cases, it would be beneficial to define the child-management
        // operations right in the base Component class. This way, you won't
        // need to expose any concrete component classes to the client code,
        // even during the object tree assembly. The downside is that these
        // methods will be empty for the leaf-level components.
        public virtual Node AddNode(Node node)
        {
            throw new NotImplementedException();
        }

        public virtual Node RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }

        // You can provide a method that lets the client code figure out whether
        // a component can bear children.
        public virtual bool IsHub()
        {
            return true;
        }
    }
}