using System;

namespace MediatorPattern
{
    internal class Tester : Colleague
    {
        public Tester(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to tester: {message}");
        }
    }
}