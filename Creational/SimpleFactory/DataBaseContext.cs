namespace Creational.SimpleFactory
{
    public class DataBaseContext : IDataBaseContext
    {
        public DataBaseContext(string connectionString, int timeOut)
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