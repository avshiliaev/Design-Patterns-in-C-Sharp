using System;

namespace StrategyPattern
{
    internal class FlyNope : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}