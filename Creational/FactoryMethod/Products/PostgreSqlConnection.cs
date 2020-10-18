using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.Products
{
    internal class PostgreSqlConnection : IDataBaseConnection
    {
        public string ApplyMigrations()
        {
            return "{Result of PostgreSqlConnection}";
        }
    }
}