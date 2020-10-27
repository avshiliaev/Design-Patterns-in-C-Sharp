using Creational.FactoryMethod.Abstractions;
using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    internal class MySqlConnectionFactory : DataBaseConnectionFactory
    {
        public override IDataBaseConnection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}