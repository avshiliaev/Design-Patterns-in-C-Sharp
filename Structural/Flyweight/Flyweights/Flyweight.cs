using System;
using System.Text.Json;
using Structural.Flyweight.Objects;

namespace Structural.Flyweight.Flyweights
{
    // The Flyweight stores a common portion of the state (also called intrinsic
    // state) that belongs to multiple real business entities. The Flyweight
    // accepts the rest of the state (extrinsic state, unique for each entity)
    // via its method parameters.
    public class Flyweight
    {
        // Intrinsic state
        private readonly UiWidget _sharedState;

        public Flyweight(UiWidget uiWidget)
        {
            _sharedState = uiWidget;
        }

        public void Operation(UiWidget uniqueState)
        {
            var s = JsonSerializer.Serialize(_sharedState);
            var u = JsonSerializer.Serialize(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}