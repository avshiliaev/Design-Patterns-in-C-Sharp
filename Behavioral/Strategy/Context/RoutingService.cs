using System;
using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Context
{
    // The Context defines the interface of interest to clients.
    internal class RoutingService
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IAlgorithm _algorithm;

        public RoutingService()
        {
        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public RoutingService(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public RoutingService SetStrategy(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
            return this;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void CreateRoute(string start, string finish)
        {
            var result = _algorithm.Solve(start, finish);

            Console.WriteLine(result);
        }
    }
}