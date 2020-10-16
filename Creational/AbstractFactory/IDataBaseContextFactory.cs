namespace Creational.AbstractFactory
{
    public interface IDataBaseContextFactory
    {
        IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut);
    }
}