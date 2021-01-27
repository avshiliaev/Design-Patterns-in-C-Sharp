using Behavioral.Visitor.Interfaces;

namespace Behavioral.Visitor.Components
{
    public class LeafNode : INode
    {
        // Same here: SerializeLeafNode => LeafNode
        public void Accept(ISerializer visitor)
        {
            visitor.SerializeLeafNode(this);
        }

        public string LeafNodeSerialization()
        {
            return "LeafNode";
        }
    }
}