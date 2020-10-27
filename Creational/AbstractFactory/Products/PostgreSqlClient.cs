using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Products
{
    // Concrete Products are created by corresponding Concrete Factories.
    internal class PostgreSqlClient : IClient
    {
        public string Query(string query)
        {
            return $"Sending query with PostgreSqlClient: ({query})";
        }

        // The variant, Product PostgreSqlClient, is only able to work correctly with the
        // variant, Product PostgreSqlSession. Nevertheless, it accepts any instance of
        // ISession as an argument.
        public string UseSession(ISession session)
        {
            var connection = session.Connect();

            return $"PostgreSqlClient ready with the connection: ({connection})";
        }
    }
}