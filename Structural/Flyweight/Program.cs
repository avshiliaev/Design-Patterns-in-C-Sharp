using System;
using Structural.Flyweight.Factories;
using Structural.Flyweight.Objects;

namespace Structural.Flyweight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory(
                new UiWidget {User = "User", Settings = "Settings", Id = "01"},
                new UiWidget {User = "User", Settings = "Settings", Id = "02"},
                new UiWidget {User = "User", Settings = "Settings", Id = "03"}
            );
            factory.ListFlyweights();

            AddWidgetToUi(factory, new UiWidget
            {
                Color = "red",
                Position = "123",

                User = "User",
                Settings = "Settings",
                Id = "04"
            });

            AddWidgetToUi(factory, new UiWidget
            {
                Color = "blue",
                Position = "456",

                User = "User",
                Settings = "Settings",
                Id = "05"
            });

            factory.ListFlyweights();
        }

        private static void AddWidgetToUi(FlyweightFactory factory, UiWidget uiWidget)
        {
            Console.WriteLine("\nClient: Adding a widget to UI.");

            var flyweight = factory.GetFlyweight(new UiWidget
            {
                Id = uiWidget.Id,
                User = uiWidget.User,
                Settings = uiWidget.Settings
            });

            // The client code either stores or calculates extrinsic state and
            // passes it to the flyweight's methods.
            flyweight.Operation(uiWidget);
        }
    }
}