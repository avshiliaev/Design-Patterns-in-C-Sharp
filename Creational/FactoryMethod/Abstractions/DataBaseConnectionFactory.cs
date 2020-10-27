using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.Abstractions
{
    internal abstract class DataBaseConnectionFactory
    {
        // Factory Method
        public abstract IDataBaseConnection CreateConnection();

        public void ConnectAndApplyMigrations()
        {
            var connection = CreateConnection();
            connection.ApplyMigrations();
        }
    }
}