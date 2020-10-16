using System;

namespace SingletonPattern
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                var chocoEggs = ChocolateBoiler.GetInstance();
                chocoEggs.Fill();
                chocoEggs.Boil();
                chocoEggs.Drain();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}