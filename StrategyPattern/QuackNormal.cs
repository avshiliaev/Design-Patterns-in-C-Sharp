using System;

namespace StrategyPattern
{
    internal class QuackNormal : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}