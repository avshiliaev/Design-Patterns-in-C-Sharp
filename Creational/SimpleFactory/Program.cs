using System;

namespace Creational.SimpleFactory
{
    internal static class Program
    {
        private static void Main()
        {
            var db = DataBaseContextFactory.CreateDataBaseContext("localhost", 30);
            Console.WriteLine($"Connected to : {db.GetConnectionString()}");
            Console.WriteLine($"With timeout of : {db.GetTimeOut()}");
        }
    }
}