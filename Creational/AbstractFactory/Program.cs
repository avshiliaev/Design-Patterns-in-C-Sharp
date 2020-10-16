using System;

namespace Creational.AbstractFactory
{
    internal static class Program
    {
        private static void Main()
        {
            var mongoDbFactory = DataBaseContextAbstractFactory.CreateDataBaseContext(DataBaseType.MongoDb);
            var mongoDbContext = mongoDbFactory.CreateDataBaseContext("localhost", 30);

            Console.WriteLine($"Connected to : {mongoDbContext.GetConnectionString()}");
            Console.WriteLine($"With timeout of : {mongoDbContext.GetTimeOut()}");
        }
    }
}