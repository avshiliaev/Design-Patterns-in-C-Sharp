namespace FlyweightPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var teaShop = new BubbleTeaShop();
            teaShop.Enumerate();
        }
    }
}