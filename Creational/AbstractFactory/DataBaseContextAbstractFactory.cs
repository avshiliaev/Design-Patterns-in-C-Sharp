namespace Creational.AbstractFactory
{
    public enum DataBaseType
    {
        PostgreSql,
        MongoDb
    }

    public abstract class DataBaseContextAbstractFactory
    {
        public static IDataBaseContextFactory CreateDataBaseContext(DataBaseType type)
        {
            switch (type)
            {
                case DataBaseType.PostgreSql:
                    return new PostgreSqlContextFactory();
                case DataBaseType.MongoDb:
                    return new MongoDbContextFactory();
                default:
                    return new PostgreSqlContextFactory();
            }
        }
    }
}