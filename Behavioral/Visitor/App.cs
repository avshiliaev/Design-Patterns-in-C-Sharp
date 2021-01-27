using System.Collections.Generic;
using Behavioral.Visitor.Interfaces;

namespace Behavioral.Visitor
{
    public static class App
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static void SerializeGraph(List<INode> nodes, ISerializer serializer)
        {
            foreach (var node in nodes)
                node.Accept(serializer);
        }
    }
}