using Structural.Proxy.Interfaces;
using Structural.Proxy.Subjects;

namespace Structural.Proxy.Proxies
{
    // The Proxy has an interface identical to the RealSubject.
    internal class DataBaseProxy : ISubject
    {
        private readonly DataBaseClient _dataBaseClient;

        public DataBaseProxy(DataBaseClient dataBaseClient)
        {
            _dataBaseClient = dataBaseClient;
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void Request()
        {
            if (CheckAccess())
            {
                _dataBaseClient.Request();

                LogAccess();
            }
        }

        private bool CheckAccess()
        {
            // Some real checks should go here.
            // ...
            return true;
        }

        private void LogAccess()
        {
            // ...
        }
    }
}