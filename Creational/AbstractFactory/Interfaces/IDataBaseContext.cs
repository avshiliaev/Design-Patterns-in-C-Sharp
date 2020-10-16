namespace Creational.AbstractFactory.Interfaces
{
    public interface IDataBaseContext
    {
        string GetConnectionString();
        int GetTimeOut();
    }
}