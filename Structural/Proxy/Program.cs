using Structural.Proxy.Proxies;
using Structural.Proxy.Subjects;

namespace Structural.Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var app = new App();

            var dataBaseClient = new DataBaseClient();
            app.CreateConnection(dataBaseClient);

            var dataBaseProxy = new DataBaseProxy(dataBaseClient);
            app.CreateConnection(dataBaseProxy);
        }
    }
}