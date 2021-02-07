namespace Creational.Singleton.Singletons
{
    public class DataBaseConnection
    {
        private static DataBaseConnection _dataBaseConnectionInstance;

        // Private constructor
        private DataBaseConnection(string connectionString)
        {
            //Hiding the Constructor
        }

        // Public constructor
        public static DataBaseConnection GetInstance(string connectionString)
        {
            if (_dataBaseConnectionInstance == null)
                _dataBaseConnectionInstance = new DataBaseConnection(connectionString);
            return _dataBaseConnectionInstance;
        }
    }
}