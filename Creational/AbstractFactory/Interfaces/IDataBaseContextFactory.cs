namespace Creational.AbstractFactory.Interfaces
{
    public interface IDataBaseContextFactory
    {
        IDataBaseContext CreateDataBaseContext(string connectionString, int timeOut);
    }
}