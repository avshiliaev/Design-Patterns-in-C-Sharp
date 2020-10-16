﻿using FactoryPattern.Abstract_Factory;
using FactoryPattern.Pizza;

namespace FactoryPattern.Factory_Method
{
    class NyPizzaFactory : PizzaFactory
    {
        protected override Pizza.Pizza Create(string type)
        {
            Pizza.Pizza pizza;
            IIngredientsFactory ingredients = new NyIngredientsFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients) {Name = "NY Style Cheese"};
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients) {Name = "NY Style Clam"};
            }
            else
            {
                pizza = new VeggiePizza(ingredients) {Name = "NY Style Veggie"};
            }
            pizza.Color = "blue";
            return pizza;
        }
    }
}
