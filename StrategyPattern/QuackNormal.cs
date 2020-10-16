using System;

namespace StrategyPattern
{
    class QuackNormal : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }      
    }
}
