using FactoryPattern.Abstract_Factory.Ingredients.Intefaces;

namespace FactoryPattern.Abstract_Factory.Ingredients
{
    internal class ThinCrust : IDough
    {
        public string Name => "Thin Crust";
    }
}