using System;
using Creational.Singleton.Singletons;

namespace Creational.Singleton
{
    public class Program
    {
        public static void Main()
        {
            var connectionString = "localhost";
            var dbConnection = DataBaseConnection.GetInstance(connectionString);
            var dbConnectionDuplicate = DataBaseConnection.GetInstance(connectionString);

            Console.WriteLine(dbConnection == dbConnectionDuplicate);
        }
    }
}