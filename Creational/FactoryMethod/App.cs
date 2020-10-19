using Creational.FactoryMethod.Abstractions;
using Creational.FactoryMethod.Factories;

namespace Creational.FactoryMethod
{
    internal class App
    {
        public void Run()
        {
            StartApp(new PostgreSqlConnectionFactory());
        }

        public void StartApp(DataBaseConnectionFactory factory)
        {
            factory.ConnectAndApplyMigrations();
        }
    }
}