namespace IteratorPattern
{
    public class Menu
    {
        public Menu(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegetarian = vegetarian;
        }

        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }
    }
}