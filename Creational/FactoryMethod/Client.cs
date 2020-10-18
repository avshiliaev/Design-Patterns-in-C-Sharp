using Creational.FactoryMethod.Abstractions;
using Creational.FactoryMethod.Factories;

namespace Creational.FactoryMethod
{
    internal class Client
    {
        public void Main()
        {
            StartApp(new PostgreSqlConnectionFactory());
        }

        public void StartApp(DataBaseConnectionFactory factory)
        {
            factory.ConnectAndApplyMigrations();
        }
    }
}