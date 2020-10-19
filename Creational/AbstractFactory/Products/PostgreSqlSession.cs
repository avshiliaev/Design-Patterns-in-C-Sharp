using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Products
{
    internal class PostgreSqlSession : ISession
    {
        // Concrete Products are created by corresponding Concrete Factories.
        public string Connect()
        {
            return "Connection to PostgreSQL.";
        }
    }
}