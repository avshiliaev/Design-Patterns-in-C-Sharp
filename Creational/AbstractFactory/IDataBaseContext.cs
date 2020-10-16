namespace Creational.AbstractFactory
{
    public interface IDataBaseContext
    {
        string GetConnectionString();
        int GetTimeOut();
    }
}