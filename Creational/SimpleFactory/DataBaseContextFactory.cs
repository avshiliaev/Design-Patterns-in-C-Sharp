namespace Creational.SimpleFactory
{
    public static class DataBaseContextFactory
    {
        public static IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut)
        {
            return new DataBaseContext(connectionString, timeOut);
        }
    }
}