namespace Creational.AbstractFactory
{
    public class PostgreSqlContextFactory : IDataBaseContextFactory
    {
        public IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut)
        {
            return new PostgreSqlContext(connectionString, timeOut);
        }
    }

    public class MongoDbContextFactory : IDataBaseContextFactory
    {
        public IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut)
        {
            return new MongoDbContext(connectionString, timeOut);
        }
    }
}