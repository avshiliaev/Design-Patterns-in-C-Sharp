using System;

namespace Creational.Builder
{
    internal static class Program
    {
        public static void Main()
        {
            var burger = new AppBuilder(4)
                .AddCors()
                .AddAuthentication()
                .AddValidation()
                .AddGrpc()
                .Build();
            Console.WriteLine(burger.GetDescription());
        }
    }
}