using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.Products
{
    internal class MongoDbConnection : IDataBaseConnection
    {
        public string ApplyMigrations()
        {
            return "{Result of MongoDbConnection}";
        }
    }
}