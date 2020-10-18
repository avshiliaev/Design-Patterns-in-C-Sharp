using Creational.AbstractFactory.Classes;
using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Factories
{
    public class MongoDbContextFactory : IDataBaseContextFactory
    {
        public IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut)
        {
            return new MongoDbContext(connectionString, timeOut);
        }
    }
}