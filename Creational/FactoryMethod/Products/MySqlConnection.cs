using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.Products
{
    internal class MySqlConnection : IDataBaseConnection
    {
        public string ApplyMigrations()
        {
            return "{Result of MySqlConnection}";
        }
    }
}