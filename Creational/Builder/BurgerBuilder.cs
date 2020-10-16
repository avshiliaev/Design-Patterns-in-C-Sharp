namespace Creational.Builder
{
    internal class BurgerBuilder
    {
        public bool Cheese;
        public bool Lettuce;
        public bool Pepperoni;
        public int Size;
        public bool Tomato;

        public BurgerBuilder(int size)
        {
            Size = size;
        }

        public BurgerBuilder AddCheese()
        {
            Cheese = true;
            return this;
        }

        public BurgerBuilder AddPepperoni()
        {
            Pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}