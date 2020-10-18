using System;

namespace Creational.Singleton
{
    public class Program
    {
        public static void Main()
        {
            var connectionString = "localhost";
            var dbOne = DataBaseConnection.GetInstance(connectionString);
            var dbTwo = DataBaseConnection.GetInstance(connectionString);

            Console.WriteLine(dbOne == dbTwo); //Output : true
        }
    }
}