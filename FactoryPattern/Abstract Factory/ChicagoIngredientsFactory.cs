using System.Collections.Generic;
using FactoryPattern.Abstract_Factory.Ingredients;
using FactoryPattern.Abstract_Factory.Ingredients.Intefaces;

namespace FactoryPattern.Abstract_Factory
{
    internal class ChicagoIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Parmesan();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FreshClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new DeepDish();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new PlumTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            var oni = new Onion();
            var ccm = new Cucumber();
            var ppr = new Pepper();
            IVeggies[] arr = { oni, ccm, ppr };
            return arr;
        }
    }
}