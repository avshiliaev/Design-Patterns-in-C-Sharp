namespace Creational.SimpleFactory
{
    public interface IDataBaseContext
    {
        string GetConnectionString();
        int GetTimeOut();
    }
}