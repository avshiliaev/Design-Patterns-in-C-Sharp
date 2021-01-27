using Behavioral.Strategy.Context;
using Behavioral.Strategy.Strategies;

namespace Behavioral.Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var routingService = new RoutingService();

            routingService
                .SetStrategy(new AlgorithmA())
                .CreateRoute("a", "b");

            routingService
                .SetStrategy(new AlgorithmB())
                .CreateRoute("c", "d");
        }
    }
}