namespace Creational.AbstractFactory.Interfaces
{
    public interface ISession
    {
        // Each distinct product of a product family should have a base interface.
        // All variants of the product must implement this interface.
        string Connect();
    }
}