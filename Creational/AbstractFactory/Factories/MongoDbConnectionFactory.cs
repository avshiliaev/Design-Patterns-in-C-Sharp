using Creational.AbstractFactory.Interfaces;
using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    internal class MongoDbConnectionFactory : IConnectionFactory
    {
        // Each Concrete Factory has a corresponding product variant.
        public ISession CreateSession()
        {
            return new MongoDbSession();
        }

        public IClient CreateClient()
        {
            return new MongoDbClient();
        }
    }
}