using System;
using Creational.AbstractFactory.Factories;
using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: IConnectionFactory and IConnection. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    internal class App
    {
        public void Run()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("App: Testing app code with the PostgreSQL factory type...");
            ConfigureCustomDataBase(new PostgreSqlConnectionFactory());

            Console.WriteLine();

            Console.WriteLine("App: Testing app code with the MongoDB factory type...");
            ConfigureCustomDataBase(new MongoDbConnectionFactory());
        }

        public void ConfigureCustomDataBase(IConnectionFactory connectionFactory)
        {
            var session = connectionFactory.CreateSession();
            var client = connectionFactory.CreateClient();

            Console.WriteLine(client.UseSession(session));
            Console.WriteLine(client.Query("SOME_QUERY"));
        }
    }
}