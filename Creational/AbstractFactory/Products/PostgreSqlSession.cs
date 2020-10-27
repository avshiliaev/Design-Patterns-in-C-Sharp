using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Products
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class PostgreSqlSession : ISession
    {
        public string Connect()
        {
            return "Connection to PostgreSQL.";
        }
    }
}