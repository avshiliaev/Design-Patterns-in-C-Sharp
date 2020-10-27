using System;
using Creational.Builder.Builders;
using Creational.Builder.Directors;

namespace Creational.Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var appBuildDirector = new AppBuildDirector();
            var webAppBuilder = new WebAppBuilder();
            appBuildDirector.Builder = webAppBuilder;

            Console.WriteLine("Building for development only:");
            appBuildDirector.BuildAppDevelopmentMode();
            Console.WriteLine(webAppBuilder.GetApp().ListMiddlewares());

            Console.WriteLine("Building for production:");
            appBuildDirector.BuildAppProductionMode();
            Console.WriteLine(webAppBuilder.GetApp().ListMiddlewares());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom app:");
            webAppBuilder.BuildInputValidation();
            webAppBuilder.BuildAuthentication();
            Console.Write(webAppBuilder.GetApp().ListMiddlewares());
        }
    }
}