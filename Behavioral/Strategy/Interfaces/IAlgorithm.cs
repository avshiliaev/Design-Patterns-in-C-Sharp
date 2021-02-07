namespace Behavioral.Strategy.Interfaces
{
    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IAlgorithm
    {
        string Solve(string start, string finish);
    }
}