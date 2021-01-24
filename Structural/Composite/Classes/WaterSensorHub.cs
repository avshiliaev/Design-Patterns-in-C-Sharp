using System.Collections.Generic;
using System.Linq;
using Structural.Composite.Abstractions;

namespace Structural.Composite.Classes
{
    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
    internal class WaterSensorHub : Node
    {
        protected List<Node> _childrenNodes = new List<Node>();

        public override Node AddNode(Node node)
        {
            _childrenNodes.Add(node);
            return this;
        }

        public override Node RemoveNode(Node node)
        {
            _childrenNodes.Remove(node);
            return this;
        }

        // The Composite executes its primary logic in a particular way. It
        // traverses recursively through all its children, collecting and
        // summing their results. Since the composite's children pass these
        // calls to their children and so forth, the whole object tree is
        // traversed as a result.
        public override double GetWaterConsumption()
        {
            return _childrenNodes.Select(n => n.GetWaterConsumption()).Sum();
        }
    }
}