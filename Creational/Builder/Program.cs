using System;

namespace Creational.Builder
{
    internal static class Program
    {
        public static void Main()
        {
            var burger = new BurgerBuilder(4)
                .AddCheese()
                .AddPepperoni()
                .AddLettuce()
                .AddTomato()
                .Build();
            Console.WriteLine(burger.GetDescription());
        }
    }
}