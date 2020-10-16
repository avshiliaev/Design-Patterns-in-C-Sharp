namespace DecoratorPattern
{
    internal class MochaCondiment : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public MochaCondiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description
        {
            get
            {
                if (_beverage.Description.StartsWith("Mocha"))
                    return "Double " + _beverage.Description;
                return "Mocha " + _beverage.Description;
            }
        }

        public override double Cost()
        {
            return 0.2 + _beverage.Cost();
        }
    }
}