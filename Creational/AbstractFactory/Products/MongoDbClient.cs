using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Products
{
    internal class MongoDbClient : IClient
    {
        public string Query(string query)
        {
            return $"Sending query with MongoDbClient: ({query})";
        }

        // The variant, Product MongoDbClient, is only able to work correctly with the
        // variant, Product MongoDbSession. Nevertheless, it accepts any instance of
        // ISession as an argument.
        public string UseSession(ISession session)
        {
            var connection = session.Connect();

            return $"MongoDbClient ready with the connection: ({connection})";
        }
    }
}