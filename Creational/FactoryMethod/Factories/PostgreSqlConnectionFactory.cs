using Creational.FactoryMethod.Abstractions;
using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    internal class PostgreSqlConnectionFactory : DataBaseConnectionFactory
    {
        public override IDataBaseConnection CreateConnection()
        {
            return new PostgreSqlConnection();
        }
    }
}