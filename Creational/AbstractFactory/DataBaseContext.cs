namespace Creational.AbstractFactory
{
    public class PostgreSqlContext : IDataBaseContext
    {
        public PostgreSqlContext(string connectionString, int timeOut)
        {
            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        private string ConnectionString { get; }
        private int TimeOut { get; }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public int GetTimeOut()
        {
            return TimeOut;
        }
    }

    public class MongoDbContext : IDataBaseContext
    {
        public MongoDbContext(string connectionString, int timeOut)
        {
            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        private string ConnectionString { get; }
        private int TimeOut { get; }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public int GetTimeOut()
        {
            return TimeOut;
        }
    }
}