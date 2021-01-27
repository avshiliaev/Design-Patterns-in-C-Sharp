using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Strategies
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    internal class AlgorithmA : IAlgorithm
    {
        public string Solve(string start, string finish)
        {
            return $"{start}->{finish}";
        }
    }
}