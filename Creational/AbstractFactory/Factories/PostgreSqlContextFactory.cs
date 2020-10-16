using Creational.AbstractFactory.Classes;
using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Factories
{
    public class PostgreSqlContextFactory : IDataBaseContextFactory
    {
        public IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut)
        {
            return new PostgreSqlContext(connectionString, timeOut);
        }
    }
}