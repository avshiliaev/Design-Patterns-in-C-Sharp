using System;

namespace StrategyPattern
{
    internal class QuackNope : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}