using System;

namespace Creational.SimpleFactory
{
    internal static class Program
    {
        private static void Main()
        {
            var door = DoorFactory.MakeDoor(80, 30);
            Console.WriteLine($"Height of Door : {door.GetHeight()}");
            Console.WriteLine($"Width of Door : {door.GetWidth()}");
        }
    }
}