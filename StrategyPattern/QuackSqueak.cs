using System;

namespace StrategyPattern
{
    internal class QuackSqueak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeeeak");
        }
    }
}