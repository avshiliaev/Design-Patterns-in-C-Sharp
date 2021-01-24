using System;
using Structural.Composite.Abstractions;

namespace Structural.Composite.Classes
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.
    internal class WaterSensor : Node
    {
        public override double GetWaterConsumption()
        {
            var rnd = new Random();
            return rnd.NextDouble();
        }

        public override bool IsHub()
        {
            return false;
        }
    }
}