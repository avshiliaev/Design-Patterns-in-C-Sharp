using System;
using Structural.Composite.Abstractions;

namespace Structural.Composite
{
    internal class App
    {
        // The client code works with all of the components via the base
        // interface.
        public void DisplayWaterConsumption(Node node)
        {
            Console.WriteLine($"RESULT: {node.GetWaterConsumption()}\n");
        }
    }
}