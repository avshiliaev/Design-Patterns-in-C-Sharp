using System;
using Behavioral.Visitor.Components;
using Behavioral.Visitor.Interfaces;

namespace Behavioral.Visitor.Visitors
{
    // Concrete Visitors implement several versions of the same algorithm, which
    // can work with all concrete component classes.
    //
    // You can experience the biggest benefit of the Visitor pattern when using
    // it with a complex object structure, such as a Composite tree. In this
    // case, it might be helpful to store some intermediate state of the
    // algorithm while executing visitor's methods over various objects of the
    // structure.
    internal class JsonSerializer : ISerializer
    {
        public void SerializeRootNode(RootNode rootNode)
        {
            Console.WriteLine(rootNode.RootNodeSerialization() + " as Json");
        }

        public void SerializeLeafNode(LeafNode leafNode)
        {
            Console.WriteLine(leafNode.LeafNodeSerialization() + " as Json");
        }
    }
}