using Creational.FactoryMethod.Abstractions;
using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    internal class MongoDbConnectionFactory : DataBaseConnectionFactory
    {
        public override IDataBaseConnection CreateConnection()
        {
            return new MongoDbConnection();
        }
    }
}