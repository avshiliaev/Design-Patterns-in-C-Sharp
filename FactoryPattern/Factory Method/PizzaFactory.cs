namespace FactoryPattern.Factory_Method
{
    abstract class PizzaFactory
    {
        public Pizza.Pizza Order(string type)
        {
            var pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza.Pizza Create(string type);
    }
}
