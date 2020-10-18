using System;

namespace Creational.Builder
{
    internal static class Program
    {
        public static void Main()
        {
            var app = new AppBuilder(4)
                .AddCors()
                .AddAuthentication()
                .AddValidation()
                .AddGrpc()
                .Build();
            Console.WriteLine(app.GetDescription());
        }
    }
}