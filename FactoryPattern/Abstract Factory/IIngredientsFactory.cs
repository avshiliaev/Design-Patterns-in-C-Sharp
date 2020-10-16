using System.Collections.Generic;
using FactoryPattern.Abstract_Factory.Ingredients.Intefaces;

namespace FactoryPattern.Abstract_Factory
{
    interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}
