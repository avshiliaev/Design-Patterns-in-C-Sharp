using Creational.Builder.Interfaces;

namespace Creational.Builder.Builders
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class WebAppBuilder : IAppBuilder
    {
        private App _app = new App();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public WebAppBuilder()
        {
            Reset();
        }

        // All production steps work with the same product instance.
        public void BuildInputValidation()
        {
            _app.AddMiddleware("ValidationMiddleware");
        }

        public void BuildAuthentication()
        {
            _app.AddMiddleware("AuthenticationMiddleware");
        }

        public void BuildAuthorization()
        {
            _app.AddMiddleware("AuthorizationMiddleware");
        }

        public void Reset()
        {
            _app = new App();
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public App GetApp()
        {
            var app = _app;

            Reset();

            return app;
        }
    }
}