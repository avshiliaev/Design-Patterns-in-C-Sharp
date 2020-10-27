using System.Collections.Generic;

namespace Creational.Builder
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class App
    {
        private readonly List<string> _middlewares = new List<string>();

        public void AddMiddleware(string middleware)
        {
            _middlewares.Add(middleware);
        }

        public string ListMiddlewares()
        {
            return string.Join(", ", _middlewares);
        }
    }
}