using System;

namespace StrategyPattern
{
    internal class FlyWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flap Flap");
        }
    }
}