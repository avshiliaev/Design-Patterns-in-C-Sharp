using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Products
{
    internal class MongoDbSession : ISession
    {
        public string Connect()
        {
            return "Connection to MongoDB.";
        }
    }
}