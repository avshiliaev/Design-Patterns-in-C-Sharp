using FactoryPattern.Abstract_Factory.Ingredients.Intefaces;

namespace FactoryPattern.Abstract_Factory.Ingredients
{
    internal class Onion : IVeggies
    {
        public Onion()
        {
        }

        public string Name => "Onions";
    }
}